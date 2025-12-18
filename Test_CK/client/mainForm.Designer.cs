namespace client
{
    partial class mainForm
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
            panel1 = new Panel();
            numTable = new NumericUpDown();
            numQuantity = new NumericUpDown();
            btnDatMon = new Button();
            lblSoLuong = new Label();
            lblMonAn = new Label();
            blbSoBan = new Label();
            txtMonAn = new TextBox();
            panel2 = new Panel();
            dgvMenu = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            txtPort = new TextBox();
            txtIP = new TextBox();
            btnThoat = new Button();
            btnConnect = new Button();
            lbltrangthai = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(numTable);
            panel1.Controls.Add(numQuantity);
            panel1.Controls.Add(btnDatMon);
            panel1.Controls.Add(lblSoLuong);
            panel1.Controls.Add(lblMonAn);
            panel1.Controls.Add(blbSoBan);
            panel1.Controls.Add(txtMonAn);
            panel1.Location = new Point(825, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 679);
            panel1.TabIndex = 0;
            // 
            // numTable
            // 
            numTable.Location = new Point(323, 49);
            numTable.Name = "numTable";
            numTable.Size = new Size(367, 39);
            numTable.TabIndex = 8;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(323, 247);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(367, 39);
            numQuantity.TabIndex = 7;
            // 
            // btnDatMon
            // 
            btnDatMon.Location = new Point(204, 431);
            btnDatMon.Name = "btnDatMon";
            btnDatMon.Size = new Size(378, 82);
            btnDatMon.TabIndex = 6;
            btnDatMon.Text = "btnOrder";
            btnDatMon.UseVisualStyleBackColor = true;
            btnDatMon.Click += btnOrder_Click;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(110, 247);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(107, 32);
            lblSoLuong.TabIndex = 5;
            lblSoLuong.Text = "so luong";
            // 
            // lblMonAn
            // 
            lblMonAn.AutoSize = true;
            lblMonAn.Location = new Point(110, 147);
            lblMonAn.Name = "lblMonAn";
            lblMonAn.Size = new Size(123, 32);
            lblMonAn.TabIndex = 4;
            lblMonAn.Text = "id mon an";
            // 
            // blbSoBan
            // 
            blbSoBan.AutoSize = true;
            blbSoBan.Location = new Point(110, 49);
            blbSoBan.Name = "blbSoBan";
            blbSoBan.Size = new Size(85, 32);
            blbSoBan.TabIndex = 3;
            blbSoBan.Text = "so ban";
            // 
            // txtMonAn
            // 
            txtMonAn.Location = new Point(323, 147);
            txtMonAn.Name = "txtMonAn";
            txtMonAn.Size = new Size(367, 39);
            txtMonAn.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvMenu);
            panel2.Location = new Point(82, 247);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 691);
            panel2.TabIndex = 1;
            // 
            // dgvMenu
            // 
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvMenu.Location = new Point(38, 34);
            dgvMenu.Name = "dgvMenu";
            dgvMenu.RowHeadersWidth = 82;
            dgvMenu.Size = new Size(606, 540);
            dgvMenu.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "ten mon";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "don gia";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbltrangthai);
            panel3.Controls.Add(txtPort);
            panel3.Controls.Add(txtIP);
            panel3.Controls.Add(btnThoat);
            panel3.Controls.Add(btnConnect);
            panel3.Location = new Point(120, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(1439, 126);
            panel3.TabIndex = 2;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(462, 65);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(202, 39);
            txtPort.TabIndex = 3;
            txtPort.Text = "8080";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(222, 65);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(202, 39);
            txtIP.TabIndex = 2;
            txtIP.Text = "172.20.10.6";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(0, 24);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(184, 80);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "thoat";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(1143, 13);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(252, 91);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "ket noi";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lbltrangthai
            // 
            lbltrangthai.AutoSize = true;
            lbltrangthai.Location = new Point(288, 13);
            lbltrangthai.Name = "lbltrangthai";
            lbltrangthai.Size = new Size(0, 32);
            lbltrangthai.TabIndex = 9;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 950);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "mainForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblSoLuong;
        private Label lblMonAn;
        private Label blbSoBan;
        private TextBox txtMonAn;
        private Panel panel2;
        private Panel panel3;
        private Button btnDatMon;
        private NumericUpDown numTable;
        private NumericUpDown numQuantity;
        private DataGridView dgvMenu;
        private Button btnThoat;
        private Button btnConnect;
        private TextBox txtPort;
        private TextBox txtIP;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label lbltrangthai;
    }
}
