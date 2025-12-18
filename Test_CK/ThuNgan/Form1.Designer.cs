namespace ThuNgan
{
    partial class FormStaff
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvOrders = new DataGridView();
            colBan = new DataGridViewTextBoxColumn();
            colMon = new DataGridViewTextBoxColumn();
            colSL = new DataGridViewTextBoxColumn();
            colGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            txtTablePay = new TextBox();
            btnConnect = new Button();
            lblTotalAmount = new Label();
            txtServerIP = new TextBox();
            btnCharge = new Button();
            btnRefresh = new Button();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colBan, colMon, colSL, colGia, colThanhTien });
            dgvOrders.Location = new Point(33, 239);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.Size = new Size(814, 289);
            dgvOrders.TabIndex = 0;
            // 
            // colBan
            // 
            colBan.HeaderText = "Số bàn";
            colBan.MinimumWidth = 8;
            colBan.Name = "colBan";
            colBan.ReadOnly = true;
            colBan.Width = 150;
            // 
            // colMon
            // 
            colMon.HeaderText = "Tên món";
            colMon.MinimumWidth = 8;
            colMon.Name = "colMon";
            colMon.ReadOnly = true;
            colMon.Width = 150;
            // 
            // colSL
            // 
            colSL.HeaderText = "Số lượng";
            colSL.MinimumWidth = 8;
            colSL.Name = "colSL";
            colSL.ReadOnly = true;
            colSL.Width = 150;
            // 
            // colGia
            // 
            colGia.HeaderText = "Đơn giá";
            colGia.MinimumWidth = 8;
            colGia.Name = "colGia";
            colGia.ReadOnly = true;
            colGia.Width = 150;
            // 
            // colThanhTien
            // 
            colThanhTien.HeaderText = "Thành Tiền";
            colThanhTien.MinimumWidth = 8;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            colThanhTien.Width = 150;
            // 
            // txtTablePay
            // 
            txtTablePay.Location = new Point(141, 23);
            txtTablePay.Name = "txtTablePay";
            txtTablePay.Size = new Size(150, 31);
            txtTablePay.TabIndex = 1;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(506, 23);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(112, 34);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(12, 26);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(94, 25);
            lblTotalAmount.TabIndex = 3;
            lblTotalAmount.Text = "Nhập bàn:";
            // 
            // txtServerIP
            // 
            txtServerIP.Location = new Point(141, 116);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(150, 31);
            txtServerIP.TabIndex = 4;
            // 
            // btnCharge
            // 
            btnCharge.Location = new Point(506, 94);
            btnCharge.Name = "btnCharge";
            btnCharge.Size = new Size(112, 34);
            btnCharge.TabIndex = 5;
            btnCharge.Text = "Charge";
            btnCharge.UseVisualStyleBackColor = true;
            btnCharge.Click += btnCharge_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(506, 169);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 119);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(93, 25);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Trạng thái:";
            // 
            // FormStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 540);
            Controls.Add(lblStatus);
            Controls.Add(btnRefresh);
            Controls.Add(btnCharge);
            Controls.Add(txtServerIP);
            Controls.Add(lblTotalAmount);
            Controls.Add(btnConnect);
            Controls.Add(txtTablePay);
            Controls.Add(dgvOrders);
            Name = "FormStaff";
            Text = "FormStaff";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private TextBox txtTablePay;
        private Button btnConnect;
        private Label lblTotalAmount;
        private TextBox txtServerIP;
        private Button btnCharge;
        private Button btnRefresh;
        private Label lblStatus;
        private DataGridViewTextBoxColumn colBan;
        private DataGridViewTextBoxColumn colMon;
        private DataGridViewTextBoxColumn colSL;
        private DataGridViewTextBoxColumn colGia;
        private DataGridViewTextBoxColumn colThanhTien;
    }
}
