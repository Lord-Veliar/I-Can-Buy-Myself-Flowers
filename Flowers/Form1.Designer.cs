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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            NameText = new TextBox();
            FFF = new TextBox();
            Email = new TextBox();
            Pass = new TextBox();
            Reg = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(558, 148);
            label1.Name = "label1";
            label1.Size = new Size(295, 62);
            label1.TabIndex = 1;
            label1.Text = "Регистрация";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.logt;
            pictureBox1.Location = new Point(629, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 133);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // NameText
            // 
            NameText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameText.BackColor = Color.FromArgb(255, 192, 255);
            NameText.BorderStyle = BorderStyle.None;
            NameText.ForeColor = SystemColors.ControlDarkDark;
            NameText.Location = new Point(646, 242);
            NameText.Name = "NameText";
            NameText.Size = new Size(100, 16);
            NameText.TabIndex = 2;
            NameText.Text = "Имя";
            NameText.TextAlign = HorizontalAlignment.Center;
            NameText.Enter += NameText_Enter;
            NameText.Leave += NameText_Leave;
            // 
            // FFF
            // 
            FFF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FFF.BackColor = Color.FromArgb(255, 192, 255);
            FFF.BorderStyle = BorderStyle.None;
            FFF.ForeColor = SystemColors.ControlDarkDark;
            FFF.Location = new Point(646, 297);
            FFF.Name = "FFF";
            FFF.Size = new Size(100, 16);
            FFF.TabIndex = 3;
            FFF.Text = "Фамилия";
            FFF.TextAlign = HorizontalAlignment.Center;
            FFF.Enter += FFF_Enter;
            FFF.Leave += FFF_Leave;
            // 
            // Email
            // 
            Email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Email.BackColor = Color.FromArgb(255, 192, 255);
            Email.BorderStyle = BorderStyle.None;
            Email.ForeColor = SystemColors.ControlDarkDark;
            Email.Location = new Point(646, 352);
            Email.Name = "Email";
            Email.Size = new Size(100, 16);
            Email.TabIndex = 4;
            Email.Text = "Email";
            Email.TextAlign = HorizontalAlignment.Center;
            Email.TextChanged += Email_TextChanged;
            Email.Enter += Email_Enter;
            Email.Leave += Email_Leave;
            // 
            // Pass
            // 
            Pass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Pass.BackColor = Color.FromArgb(255, 192, 255);
            Pass.BorderStyle = BorderStyle.None;
            Pass.ForeColor = SystemColors.ControlDarkDark;
            Pass.Location = new Point(646, 407);
            Pass.Name = "Pass";
            Pass.Size = new Size(100, 16);
            Pass.TabIndex = 5;
            Pass.Text = "Пароль";
            Pass.TextAlign = HorizontalAlignment.Center;
            Pass.Enter += Pass_Enter;
            Pass.Leave += Pass_Leave;
            // 
            // Reg
            // 
            Reg.Anchor = AnchorStyles.Top;
            Reg.BackColor = Color.FromArgb(142, 213, 228);
            Reg.Location = new Point(596, 451);
            Reg.Name = "Reg";
            Reg.Size = new Size(219, 40);
            Reg.TabIndex = 6;
            Reg.Text = "Зарегестрироваться";
            Reg.UseVisualStyleBackColor = false;
            Reg.Click += Reg_Click;
            // 
            // button1
            // 
            button1.Location = new Point(662, 513);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // I_Can_Buy_Myself_Flowers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1457, 590);
            Controls.Add(button1);
            Controls.Add(Reg);
            Controls.Add(Pass);
            Controls.Add(Email);
            Controls.Add(FFF);
            Controls.Add(NameText);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "I_Can_Buy_Myself_Flowers";
            Text = "I Can Buy Myself Flowers";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        public TextBox NameText;
        public TextBox FFF;
        public TextBox Email;
        public TextBox Pass;
        private Button Reg;
        private Button button1;
    }
}