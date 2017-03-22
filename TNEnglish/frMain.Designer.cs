namespace TNEnglish
{
    partial class frMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.panelDangNhap = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbThoat = new System.Windows.Forms.Label();
            this.panelWord = new System.Windows.Forms.Panel();
            this.panelWordTwo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtInputWord = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.pictureBoxWord2 = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelTienTrinh = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelWordOne = new System.Windows.Forms.Panel();
            this.lbMean = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.lbWordRem = new System.Windows.Forms.Label();
            this.lbWord = new System.Windows.Forms.Label();
            this.pictureBoxWord = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panelTotal = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelDangNhap.SuspendLayout();
            this.panelWord.SuspendLayout();
            this.panelWordTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panelWordOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord)).BeginInit();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDangNhap
            // 
            this.panelDangNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDangNhap.Controls.Add(this.panelTotal);
            this.panelDangNhap.Controls.Add(this.label7);
            this.panelDangNhap.Controls.Add(this.label6);
            this.panelDangNhap.Controls.Add(this.txtPassword);
            this.panelDangNhap.Controls.Add(this.txtUsername);
            this.panelDangNhap.Controls.Add(this.label4);
            this.panelDangNhap.Controls.Add(this.label3);
            this.panelDangNhap.Controls.Add(this.button1);
            this.panelDangNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDangNhap.Location = new System.Drawing.Point(27, 48);
            this.panelDangNhap.Name = "panelDangNhap";
            this.panelDangNhap.Size = new System.Drawing.Size(838, 445);
            this.panelDangNhap.TabIndex = 3;
            this.panelDangNhap.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDangNhap_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Location = new System.Drawing.Point(317, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ứng dụng học tiếng anh hàng đầu Việt Nam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(351, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "TNEnglish";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(375, 189);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(186, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(375, 147);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(186, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tài khoản";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbName.Location = new System.Drawing.Point(453, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(277, 23);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Tiến Nguyễn";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbThoat
            // 
            this.lbThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThoat.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoat.Location = new System.Drawing.Point(736, 12);
            this.lbThoat.Name = "lbThoat";
            this.lbThoat.Size = new System.Drawing.Size(103, 23);
            this.lbThoat.TabIndex = 2;
            this.lbThoat.Text = "(Đăng xuất)";
            this.lbThoat.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelWord
            // 
            this.panelWord.BackColor = System.Drawing.SystemColors.Control;
            this.panelWord.Controls.Add(this.panelWordTwo);
            this.panelWord.Controls.Add(this.axWindowsMediaPlayer1);
            this.panelWord.Controls.Add(this.panelTienTrinh);
            this.panelWord.Controls.Add(this.button2);
            this.panelWord.Controls.Add(this.panelWordOne);
            this.panelWord.Location = new System.Drawing.Point(149, 305);
            this.panelWord.Name = "panelWord";
            this.panelWord.Size = new System.Drawing.Size(838, 449);
            this.panelWord.TabIndex = 10;
            // 
            // panelWordTwo
            // 
            this.panelWordTwo.BackColor = System.Drawing.Color.Azure;
            this.panelWordTwo.Controls.Add(this.pictureBox3);
            this.panelWordTwo.Controls.Add(this.pictureBox2);
            this.panelWordTwo.Controls.Add(this.pictureBox1);
            this.panelWordTwo.Controls.Add(this.txtInputWord);
            this.panelWordTwo.Controls.Add(this.labelText);
            this.panelWordTwo.Controls.Add(this.pictureBoxWord2);
            this.panelWordTwo.Location = new System.Drawing.Point(29, 62);
            this.panelWordTwo.Name = "panelWordTwo";
            this.panelWordTwo.Size = new System.Drawing.Size(732, 278);
            this.panelWordTwo.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(693, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 27);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(650, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 27);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(604, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 27);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtInputWord
            // 
            this.txtInputWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputWord.ForeColor = System.Drawing.Color.Blue;
            this.txtInputWord.Location = new System.Drawing.Point(47, 217);
            this.txtInputWord.Name = "txtInputWord";
            this.txtInputWord.Size = new System.Drawing.Size(647, 47);
            this.txtInputWord.TabIndex = 0;
            this.txtInputWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInputWord.TextChanged += new System.EventHandler(this.txtInputWord_TextChanged);
            this.txtInputWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInputWord_KeyUp);
            // 
            // labelText
            // 
            this.labelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelText.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.Blue;
            this.labelText.Location = new System.Drawing.Point(39, 24);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(655, 158);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "label5";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxWord2
            // 
            this.pictureBoxWord2.Location = new System.Drawing.Point(248, 4);
            this.pictureBoxWord2.Name = "pictureBoxWord2";
            this.pictureBoxWord2.Size = new System.Drawing.Size(252, 207);
            this.pictureBoxWord2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWord2.TabIndex = 0;
            this.pictureBoxWord2.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(813, 436);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 10);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // panelTienTrinh
            // 
            this.panelTienTrinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTienTrinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTienTrinh.Location = new System.Drawing.Point(50, 31);
            this.panelTienTrinh.Name = "panelTienTrinh";
            this.panelTienTrinh.Size = new System.Drawing.Size(732, 26);
            this.panelTienTrinh.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(372, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Bắt đầu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelWordOne
            // 
            this.panelWordOne.BackColor = System.Drawing.Color.Azure;
            this.panelWordOne.Controls.Add(this.lbMean);
            this.panelWordOne.Controls.Add(this.buttonEdit);
            this.panelWordOne.Controls.Add(this.lbWordRem);
            this.panelWordOne.Controls.Add(this.lbWord);
            this.panelWordOne.Controls.Add(this.pictureBoxWord);
            this.panelWordOne.Location = new System.Drawing.Point(32, 346);
            this.panelWordOne.Name = "panelWordOne";
            this.panelWordOne.Size = new System.Drawing.Size(732, 286);
            this.panelWordOne.TabIndex = 0;
            this.panelWordOne.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lbMean
            // 
            this.lbMean.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMean.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMean.Location = new System.Drawing.Point(295, 102);
            this.lbMean.Name = "lbMean";
            this.lbMean.Size = new System.Drawing.Size(417, 119);
            this.lbMean.TabIndex = 4;
            this.lbMean.Text = "label9";
            this.lbMean.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(637, 249);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Chỉnh sửa";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // lbWordRem
            // 
            this.lbWordRem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWordRem.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWordRem.Location = new System.Drawing.Point(292, 61);
            this.lbWordRem.Name = "lbWordRem";
            this.lbWordRem.Size = new System.Drawing.Size(437, 24);
            this.lbWordRem.TabIndex = 2;
            this.lbWordRem.Text = "Re-mem-ber";
            this.lbWordRem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbWordRem.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbWord
            // 
            this.lbWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWord.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWord.ForeColor = System.Drawing.Color.Blue;
            this.lbWord.Location = new System.Drawing.Point(292, 20);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(437, 41);
            this.lbWord.TabIndex = 1;
            this.lbWord.Text = "Remember";
            this.lbWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxWord
            // 
            this.pictureBoxWord.Location = new System.Drawing.Point(18, 20);
            this.pictureBoxWord.Name = "pictureBoxWord";
            this.pictureBoxWord.Size = new System.Drawing.Size(250, 252);
            this.pictureBoxWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWord.TabIndex = 0;
            this.pictureBoxWord.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1200;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.SystemColors.Control;
            this.panelTotal.Controls.Add(this.label11);
            this.panelTotal.Controls.Add(this.label10);
            this.panelTotal.Controls.Add(this.label9);
            this.panelTotal.Controls.Add(this.label8);
            this.panelTotal.Controls.Add(this.label5);
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Location = new System.Drawing.Point(267, 273);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(840, 450);
            this.panelTotal.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(270, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "label11";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(270, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(270, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Congratulations!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số lần nhập sai: ";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số từ đã nhớ:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Blue;
            this.labelTotal.Location = new System.Drawing.Point(267, 21);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(107, 37);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total";
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 486);
            this.Controls.Add(this.panelWord);
            this.Controls.Add(this.lbThoat);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.panelDangNhap);
            this.MaximizeBox = false;
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TNEnglish";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDangNhap.ResumeLayout(false);
            this.panelDangNhap.PerformLayout();
            this.panelWord.ResumeLayout(false);
            this.panelWordTwo.ResumeLayout(false);
            this.panelWordTwo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panelWordOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord)).EndInit();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDangNhap;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbThoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelWord;
        private System.Windows.Forms.Panel panelWordOne;
        private System.Windows.Forms.PictureBox pictureBoxWord;
        private System.Windows.Forms.Label lbMean;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label lbWordRem;
        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.Panel panelWordTwo;
        private System.Windows.Forms.PictureBox pictureBoxWord2;
        private System.Windows.Forms.TextBox txtInputWord;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelTienTrinh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;

    }
}

