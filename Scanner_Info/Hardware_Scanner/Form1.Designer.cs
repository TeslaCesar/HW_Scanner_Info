namespace Hardware_Scanner
{
    partial class frmInfoScanner
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
            components = new System.ComponentModel.Container();
            btnExit = new Button();
            txtCPUModel = new TextBox();
            txtBIOSnumber = new TextBox();
            txtMBModel = new TextBox();
            txtWIFImac = new TextBox();
            txtMACethernet = new TextBox();
            txtBIOSversion = new TextBox();
            txtMBManufacturer = new TextBox();
            label1 = new Label();
            btnAbout = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            lblGIThub = new LinkLabel();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(224, 224, 224);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(522, 408);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 30);
            btnExit.TabIndex = 0;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtCPUModel
            // 
            txtCPUModel.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtCPUModel.Location = new Point(30, 113);
            txtCPUModel.Name = "txtCPUModel";
            txtCPUModel.PlaceholderText = "CPU Model";
            txtCPUModel.ReadOnly = true;
            txtCPUModel.Size = new Size(406, 29);
            txtCPUModel.TabIndex = 1;
            // 
            // txtBIOSnumber
            // 
            txtBIOSnumber.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBIOSnumber.Location = new Point(30, 312);
            txtBIOSnumber.Name = "txtBIOSnumber";
            txtBIOSnumber.PlaceholderText = "Serial Number";
            txtBIOSnumber.ReadOnly = true;
            txtBIOSnumber.Size = new Size(231, 29);
            txtBIOSnumber.TabIndex = 2;
            txtBIOSnumber.Click += txtBIOSnumber_Click;
            // 
            // txtMBModel
            // 
            txtMBModel.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMBModel.Location = new Point(30, 179);
            txtMBModel.Name = "txtMBModel";
            txtMBModel.PlaceholderText = "MB Model";
            txtMBModel.ReadOnly = true;
            txtMBModel.Size = new Size(305, 29);
            txtMBModel.TabIndex = 3;
            // 
            // txtWIFImac
            // 
            txtWIFImac.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtWIFImac.Location = new Point(378, 179);
            txtWIFImac.Name = "txtWIFImac";
            txtWIFImac.PlaceholderText = "MAC Wifi";
            txtWIFImac.ReadOnly = true;
            txtWIFImac.Size = new Size(228, 29);
            txtWIFImac.TabIndex = 4;
            txtWIFImac.Click += txtWIFImac_Click;
            // 
            // txtMACethernet
            // 
            txtMACethernet.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMACethernet.Location = new Point(378, 247);
            txtMACethernet.Name = "txtMACethernet";
            txtMACethernet.PlaceholderText = "MAC Ethernet";
            txtMACethernet.ReadOnly = true;
            txtMACethernet.Size = new Size(228, 29);
            txtMACethernet.TabIndex = 5;
            txtMACethernet.Click += txtMACethernet_Click;
            // 
            // txtBIOSversion
            // 
            txtBIOSversion.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBIOSversion.Location = new Point(30, 375);
            txtBIOSversion.Name = "txtBIOSversion";
            txtBIOSversion.PlaceholderText = "BIOS Version";
            txtBIOSversion.ReadOnly = true;
            txtBIOSversion.Size = new Size(231, 29);
            txtBIOSversion.TabIndex = 6;
            // 
            // txtMBManufacturer
            // 
            txtMBManufacturer.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMBManufacturer.Location = new Point(30, 247);
            txtMBManufacturer.Name = "txtMBManufacturer";
            txtMBManufacturer.PlaceholderText = "MB Brand";
            txtMBManufacturer.ReadOnly = true;
            txtMBManufacturer.Size = new Size(277, 29);
            txtMBManufacturer.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(351, 56);
            label1.TabIndex = 8;
            label1.Text = "Hardware Info";
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.FromArgb(224, 224, 224);
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbout.ForeColor = Color.Black;
            btnAbout.Location = new Point(421, 408);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(84, 30);
            btnAbout.TabIndex = 9;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(383, 156);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 10;
            label2.Text = "Wi-Fi MAC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(383, 225);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 11;
            label3.Text = "Ethernet MAC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(30, 225);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 13;
            label4.Text = "MB Brand";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(30, 156);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 12;
            label5.Text = "MB Model";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkOrange;
            label6.Location = new Point(32, 289);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 14;
            label6.Text = "Serial Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkOrange;
            label7.Location = new Point(32, 353);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 15;
            label7.Text = "BIOS Version";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // lblGIThub
            // 
            lblGIThub.AutoSize = true;
            lblGIThub.LinkColor = Color.FromArgb(255, 128, 0);
            lblGIThub.Location = new Point(7, 427);
            lblGIThub.Name = "lblGIThub";
            lblGIThub.Size = new Size(45, 15);
            lblGIThub.TabIndex = 16;
            lblGIThub.TabStop = true;
            lblGIThub.Text = "GitHub";
            lblGIThub.LinkClicked += lblGIThub_LinkClicked;
            // 
            // frmInfoScanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 29, 56);
            ClientSize = new Size(618, 450);
            ControlBox = false;
            Controls.Add(lblGIThub);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAbout);
            Controls.Add(label1);
            Controls.Add(txtMBManufacturer);
            Controls.Add(txtBIOSversion);
            Controls.Add(txtMACethernet);
            Controls.Add(txtWIFImac);
            Controls.Add(txtMBModel);
            Controls.Add(txtBIOSnumber);
            Controls.Add(txtCPUModel);
            Controls.Add(btnExit);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInfoScanner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scanner HW Info";
            Load += frmInfoScanner_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private TextBox txtCPUModel;
        private TextBox txtBIOSnumber;
        private TextBox txtMBModel;
        private TextBox txtWIFImac;
        private TextBox txtMACethernet;
        private TextBox txtBIOSversion;
        private TextBox txtMBManufacturer;
        private Label label1;
        private Button btnAbout;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private NotifyIcon notifyIcon1;
        private LinkLabel lblGIThub;
    }
}
