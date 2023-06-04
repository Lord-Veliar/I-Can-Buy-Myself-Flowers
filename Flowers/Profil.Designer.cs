namespace Flowers
{
    partial class Profil
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            RedIm = new TextBox();
            RedFm = new TextBox();
            RedEm = new TextBox();
            RedPass = new TextBox();
            ResSave = new Button();
            Rednpass = new TextBox();
            label5 = new Label();
            izmp = new Button();
            izmpar = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 125);
            label1.Name = "label1";
            label1.Size = new Size(55, 30);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(266, 125);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 1;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(55, 209);
            label3.Name = "label3";
            label3.Size = new Size(73, 30);
            label3.TabIndex = 2;
            label3.Text = "Почта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(50, 293);
            label4.Name = "label4";
            label4.Size = new Size(166, 30);
            label4.TabIndex = 3;
            label4.Text = "Старый пароль";
            // 
            // RedIm
            // 
            RedIm.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RedIm.Location = new Point(55, 158);
            RedIm.Name = "RedIm";
            RedIm.Size = new Size(164, 33);
            RedIm.TabIndex = 4;
            // 
            // RedFm
            // 
            RedFm.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RedFm.Location = new Point(266, 158);
            RedFm.Name = "RedFm";
            RedFm.Size = new Size(164, 33);
            RedFm.TabIndex = 5;
            // 
            // RedEm
            // 
            RedEm.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            RedEm.Location = new Point(55, 240);
            RedEm.Name = "RedEm";
            RedEm.Size = new Size(164, 33);
            RedEm.TabIndex = 6;
            // 
            // RedPass
            // 
            RedPass.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RedPass.Location = new Point(55, 335);
            RedPass.Name = "RedPass";
            RedPass.Size = new Size(164, 33);
            RedPass.TabIndex = 7;
            // 
            // ResSave
            // 
            ResSave.BackColor = Color.FromArgb(142, 213, 228);
            ResSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ResSave.Location = new Point(464, 158);
            ResSave.Name = "ResSave";
            ResSave.Size = new Size(114, 33);
            ResSave.TabIndex = 8;
            ResSave.Text = "Сохранить";
            ResSave.UseVisualStyleBackColor = false;
            ResSave.Click += ResSave_Click;
            // 
            // Rednpass
            // 
            Rednpass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Rednpass.Location = new Point(266, 335);
            Rednpass.Name = "Rednpass";
            Rednpass.Size = new Size(164, 33);
            Rednpass.TabIndex = 9;
            Rednpass.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(266, 302);
            label5.Name = "label5";
            label5.Size = new Size(160, 30);
            label5.TabIndex = 10;
            label5.Text = "Новый пароль";
            // 
            // izmp
            // 
            izmp.BackColor = Color.FromArgb(142, 213, 228);
            izmp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            izmp.Location = new Point(266, 240);
            izmp.Name = "izmp";
            izmp.Size = new Size(178, 33);
            izmp.TabIndex = 13;
            izmp.Text = "Изменить почту";
            izmp.UseVisualStyleBackColor = false;
            izmp.Click += izmp_Click;
            // 
            // izmpar
            // 
            izmpar.BackColor = Color.FromArgb(142, 213, 228);
            izmpar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            izmpar.Location = new Point(464, 335);
            izmpar.Name = "izmpar";
            izmpar.Size = new Size(188, 33);
            izmpar.TabIndex = 14;
            izmpar.Text = "Изменить пароль";
            izmpar.UseVisualStyleBackColor = false;
            izmpar.Click += izmpar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(197, 235, 207);
            pictureBox1.Location = new Point(-3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1091, 108);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(197, 235, 207);
            label6.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(55, 22);
            label6.Name = "label6";
            label6.Size = new Size(237, 65);
            label6.TabIndex = 16;
            label6.Text = "Профиль";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(0, 64, 0);
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(197, 235, 207);
            linkLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(938, 37);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(114, 32);
            linkLabel1.TabIndex = 49;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Профиль";
            linkLabel1.VisitedLinkColor = Color.Black;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.FromArgb(0, 64, 0);
            linkLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.FromArgb(197, 235, 207);
            linkLabel2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(768, 37);
            linkLabel2.Margin = new Padding(2, 0, 2, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(107, 32);
            linkLabel2.TabIndex = 48;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Корзина";
            linkLabel2.VisitedLinkColor = Color.Black;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(142, 213, 228);
            pictureBox2.Location = new Point(13, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 10);
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(142, 213, 228);
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Location = new Point(13, 54);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 11);
            pictureBox3.TabIndex = 51;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(142, 213, 228);
            pictureBox4.Location = new Point(13, 71);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 10);
            pictureBox4.TabIndex = 52;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(197, 235, 207);
            pictureBox5.Location = new Point(10, 37);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 50);
            pictureBox5.TabIndex = 53;
            pictureBox5.TabStop = false;
            // 
            // Profil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 481);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel1);
            Controls.Add(linkLabel2);
            Controls.Add(label6);
            Controls.Add(izmpar);
            Controls.Add(izmp);
            Controls.Add(label5);
            Controls.Add(Rednpass);
            Controls.Add(ResSave);
            Controls.Add(RedPass);
            Controls.Add(RedEm);
            Controls.Add(RedFm);
            Controls.Add(RedIm);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Name = "Profil";
            Text = "Profil";
            Load += Profil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox RedIm;
        public TextBox RedFm;
        public TextBox RedEm;
        public TextBox RedPass;
        private Button ResSave;
        private TextBox Rednpass;
        private Label label5;
        private Button izmp;
        private Button izmpar;
        private PictureBox pictureBox1;
        private Label label6;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}