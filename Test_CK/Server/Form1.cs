using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Server
{
    public partial class Form1 : Form
    {
        string ip = "";
        int port;

        List<MenuItem> listMenu = new List<MenuItem>();
        List<OrderItem> listOrders = new List<OrderItem>();
        TcpListener server;
        bool isRunning = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            // Cho phép thread khác cập nhật giao diện
            CheckForIllegalCrossThreadCalls = false;
            port = int.Parse(txtPort.Text);

            Thread serverThread = new Thread(new ThreadStart(StartServer));
            serverThread.IsBackground = true;
            serverThread.Start();

        }

        void StartServer()
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();
            isRunning = true;
            btnListen.Enabled = false;
            Log("Server đang chạy...");
            Task.Run(() => AcceptClients()); // Chạy vòng lặp chấp nhận client ở luồng riêng
        }

        void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

            try
            {
                while (isRunning)
                {
                    string request = reader.ReadLine();
                    if (string.IsNullOrEmpty(request)) break;

                    Log($"Nhận từ {client.Client.RemoteEndPoint}: {request}");

                    string[] parts = request.Split(' ');
                    string command = parts[0];

                    switch (command)
                    {
                        case "MENU":
                            // Gửi chuỗi menu: ID;Ten;Gia|ID;Ten;Gia...
                            string menuData = string.Join("|", listMenu.Select(m => $"{m.ID};{m.Name};{m.Price}"));
                            writer.WriteLine(menuData);
                            break;

                        case "ORDER":
                            // Định dạng: ORDER TableID;FoodID;Qty
                            string[] orderData = parts[1].Split(';');
                            int tableId = int.Parse(orderData[0]);
                            int foodId = int.Parse(orderData[1]);
                            int qty = int.Parse(orderData[2]);

                            var food = listMenu.FirstOrDefault(f => f.ID == foodId);
                            if (food != null)
                            {
                                listOrders.Add(new OrderItem
                                {
                                    TableID = tableId,
                                    FoodName = food.Name,
                                    Quantity = qty,
                                    Price = food.Price
                                });
                                writer.WriteLine("OK");
                            }
                            else
                            {
                                writer.WriteLine("ERROR");
                            }
                            break;

                        case "GET_ORDERS":
                            // Trả về toàn bộ order hiện có
                            string allOrders = string.Join("|", listOrders.Select(o => $"{o.TableID};{o.FoodName};{o.Quantity};{o.Price}"));
                            writer.WriteLine(allOrders);
                            break;

                        case "PAY":
                            // Định dạng: PAY TableID
                            int payTableId = int.Parse(parts[1]);
                            var tableOrders = listOrders.Where(o => o.TableID == payTableId).ToList();
                            double total = tableOrders.Sum(o => o.Price * o.Quantity);

                            // Xóa đơn hàng sau khi thanh toán
                            listOrders.RemoveAll(o => o.TableID == payTableId);
                            writer.WriteLine(total.ToString());
                            break;

                        case "QUIT":
                            writer.WriteLine("BYE");
                            return;
                    }
                }
            }
            catch (Exception ex)
            {
                Log("Lỗi: " + ex.Message);
            }
            finally
            {
                client.Close();
            }
        }

        void AcceptClients()
        {
            while (isRunning)
            {
                TcpClient client = server.AcceptTcpClient();
                // Mỗi client một luồng xử lý riêng
                Task.Run(() => HandleClient(client));
            }
        }

        void Log(string message)
        {
            rtbLog.Invoke(new Action(() => {
                rtbLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\n");
            }));
        }

        public class MenuItem
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
        }

        public class OrderItem
        {
            public int TableID { get; set; }
            public string FoodName { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; } 
        }

        void LoadMenu()
        {
            string path = "menu.txt";
            if (!File.Exists(path))
            {
                // Tự tạo file menu mẫu nếu chưa có
                string[] defaultMenu = { "1;Cafe Den;20000", "2;Cafe Sua;25000", "3;Com Tam;45000" };
                File.WriteAllLines(path, defaultMenu);
            }

            listMenu.Clear();
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length == 3)
                    listMenu.Add(new MenuItem { ID = int.Parse(parts[0]), Name = parts[1], Price = double.Parse(parts[2]) });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            LoadMenu();
        }
    }
}
