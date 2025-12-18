using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
namespace client
{
    public partial class mainForm : Form
    {
        TcpClient tcpClient;
        NetworkStream stream;
        public mainForm()
        {
            InitializeComponent();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // conect to sever

                tcpClient = new TcpClient("10.255.96.1", 8080);
                stream = tcpClient.GetStream();
                txtIP.Text = "172.20.10.6";
                txtPort.Text = "8080";
                // toi la khach hang
                SendData("AUTH CUSTOMER");
                // lay menun
                SendData("MENU");
                string response = ReceiveData();
                DisplayMenu(response);
                lbltrangthai.Text = "Đã kết nối đến server:";
                MessageBox.Show("Đã kết nối và tải Menu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
        private void DisplayMenu(string data)
        {
            dgvMenu.Rows.Clear();
            // Tách các món ăn bằng dấu |
            string[] items = data.Split('|');
            foreach (string item in items)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    // Tách ID;Tên;Giá
                    string[] details = item.Split(';');
                    if (details.Length == 3)
                    {
                        dgvMenu.Rows.Add(details[0], details[1], details[2]);
                    }
                }
            }
        }
        //lay menu
        private void SendData(string message)
        {
            if (stream != null)
            {
                byte[] data = Encoding.UTF8.GetBytes(message + "\n");
                stream.Write(data, 0, data.Length);
            }
        }
        //nhan menu
        private string ReceiveData()
        {
            if (stream != null)
            {
                byte[] buffer = new byte[4096];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                return Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();
            }
            return "";
        }
        //hien thi menu
        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow == null) return;
            string soBan = numTable.Value.ToString();
            string monan = txtMonAn.Text; // Lấy ID ở cột đầu tiên
            string soLuong = numQuantity.Value.ToString();
            string id = dgvMenu.CurrentRow.Cells[0].Value.ToString();
            SendData($"ORDER {soBan};{id};{soLuong}");
            string res = ReceiveData();
            if (res.StartsWith("OK"))
            {
                MessageBox.Show("Đặt thành công!");
            }
            else
            {
                MessageBox.Show("Thất bại: " + res);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (tcpClient != null)
            {
                SendData("QUIT");
                tcpClient.Close();
            }
            this.Close();
        }
    }
}


