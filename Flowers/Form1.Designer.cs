namespace Flowers
{
    partial class I_Can_Buy_Myself_Flowers
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.FFF = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Reg = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(558, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Регистрация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Flowers.Properties.Resources.logt;
            this.pictureBox1.Location = new System.Drawing.Point(629, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NameText
            // 
            this.NameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NameText.Location = new System.Drawing.Point(629, 256);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(117, 23);
            this.NameText.TabIndex = 2;
            this.NameText.Text = "Имя";
            this.NameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameText.Enter += new System.EventHandler(this.NameText_Enter);
            this.NameText.Leave += new System.EventHandler(this.NameText_Leave);
            // 
            // FFF
            // 
            this.FFF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FFF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FFF.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FFF.Location = new System.Drawing.Point(629, 302);
            this.FFF.Name = "FFF";
            this.FFF.Size = new System.Drawing.Size(117, 23);
            this.FFF.TabIndex = 3;
            this.FFF.Text = "Фамилия";
            this.FFF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FFF.Enter += new System.EventHandler(this.FFF_Enter);
            this.FFF.Leave += new System.EventHandler(this.FFF_Leave);
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Email.Location = new System.Drawing.Point(629, 345);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(117, 23);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Enter += new System.EventHandler(this.Email_Enter);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // Pass
            // 
            this.Pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pass.Location = new System.Drawing.Point(629, 390);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(117, 23);
            this.Pass.TabIndex = 5;
            this.Pass.Text = "Пароль";
            this.Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pass.Enter += new System.EventHandler(this.Pass_Enter);
            this.Pass.Leave += new System.EventHandler(this.Pass_Leave);
            // 
            // Reg
            // 
            this.Reg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(213)))), ((int)(((byte)(228)))));
            this.Reg.Location = new System.Drawing.Point(582, 451);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(219, 40);
            this.Reg.TabIndex = 6;
            this.Reg.Text = "Зарегестрироваться";
            this.Reg.UseVisualStyleBackColor = false;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(623, 505);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 21);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Уже есть аккаунт?";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // I_Can_Buy_Myself_Flowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1457, 590);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.FFF);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "I_Can_Buy_Myself_Flowers";
            this.Text = "I Can Buy Myself Flowers";
            this.Load += new System.EventHandler(this.I_Can_Buy_Myself_Flowers_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        public TextBox NameText;
        public TextBox FFF;
        public TextBox Email;
        public TextBox Pass;
        private Button Reg;
        private LinkLabel linkLabel1;
    }
}