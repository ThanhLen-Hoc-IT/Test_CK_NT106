using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Linq;

namespace ThuNgan
{
    public partial class FormStaff : Form
    {
        TcpClient client;
        NetworkStream stream;
        
        StreamReader reader;

        public FormStaff()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("10.255.96.1", 8080);
                stream = client.GetStream();
                reader = new StreamReader(stream, Encoding.UTF8);

                SendMessage("AUTH STAFF");

                Thread listenThread = new Thread(ReceiveData);
                listenThread.IsBackground = true;
                listenThread.Start();

                btnConnect.Enabled = false;
                lblStatus.Text = "Đã kết nối Server!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void SendMessage(string msg)
        {
            if (stream != null && client.Connected)
            {
                byte[] data = Encoding.UTF8.GetBytes(msg + "\n");
                stream.Write(data, 0, data.Length);
            }
        }

        private void ReceiveData()
        {
            try
            {
                while (client != null && client.Connected)
                {
                    string response = reader.ReadLine();
                    if (response == null) break;

                   
                    this.Invoke(new Action(() => {
                        ProcessServerResponse(response.Trim());
                    }));
                }
            }
            catch { }
        }

        private void ProcessServerResponse(string response)
        {
            if (string.IsNullOrEmpty(response)) return;

            
            if (response.Contains(";") && response.Contains("|") || (response.Split(';').Length >= 4))
            {
                dgvOrders.Rows.Clear();
                string[] parts = response.Split('|');

                foreach (string part in parts)
                {
                    if (string.IsNullOrEmpty(part)) continue;
                    string[] item = part.Split(';');
                    if (item.Length >= 4)
                    {
                        try
                        {
                            double qty = double.Parse(item[2]);
                            double price = double.Parse(item[3]);
                            double thanhTien = qty * price;
                            dgvOrders.Rows.Add(item[0], item[1], item[2], item[3], thanhTien);
                        }
                        catch { }
                    }
                }
            }
          
            else if (double.TryParse(response, out double totalAmount))
            {
                lblTotalAmount.Text = String.Format("{0:N0} VNĐ", totalAmount);
               
                string tableNum = txtTablePay.Text;
                ExportBillToFile(tableNum, totalAmount.ToString());

                
                SendMessage("GET_ORDERS");
            }
            
            else
            {
                Console.WriteLine("Server thông báo: " + response);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SendMessage("GET_ORDERS");
        }

        private void btnCharge_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTablePay.Text))
            {
                SendMessage("PAY " + txtTablePay.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số bàn để tính tiền!");
            }
        }

        private void ExportBillToFile(string tableNum, string total)
        {
            try
            {
                string path = $"bill_Ban{tableNum}.txt";
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("      HÓA ĐƠN NHÀ HÀNG");
                    sw.WriteLine($"Bàn số: {tableNum}");
                    sw.WriteLine($"Thời gian: {DateTime.Now}");
                    sw.WriteLine("---------------------------------");
                    sw.WriteLine("{0,-15} {1,-5} {2,-10}", "Món", "SL", "Giá");

                    foreach (DataGridViewRow row in dgvOrders.Rows)
                    {
                        if (row.Cells[0].Value?.ToString() == tableNum)
                        {
                            sw.WriteLine("{0,-15} {1,-5} {2,-10}",
                                row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value);
                        }
                    }
                    sw.WriteLine("---------------------------------");
                    sw.WriteLine($"TỔNG CỘNG: {double.Parse(total):N0} VNĐ");
                    sw.WriteLine("Cảm ơn quý khách!");
                }
                MessageBox.Show($"Đã thanh toán và xuất hóa đơn tại {path}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất file: " + ex.Message);
            }
        }

        private void FormStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SendMessage("QUIT");
                client?.Close();
            }
            catch { }
        }
    }
}