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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RedIm = new System.Windows.Forms.TextBox();
            this.RedFm = new System.Windows.Forms.TextBox();
            this.RedEm = new System.Windows.Forms.TextBox();
            this.RedPass = new System.Windows.Forms.TextBox();
            this.ResSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Почта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Старый Пароль";
            // 
            // RedIm
            // 
            this.RedIm.Location = new System.Drawing.Point(293, 92);
            this.RedIm.Name = "RedIm";
            this.RedIm.Size = new System.Drawing.Size(100, 23);
            this.RedIm.TabIndex = 4;
            this.RedIm.TextChanged += new System.EventHandler(this.RedIm_TextChanged);
            // 
            // RedFm
            // 
            this.RedFm.Location = new System.Drawing.Point(354, 189);
            this.RedFm.Name = "RedFm";
            this.RedFm.Size = new System.Drawing.Size(100, 23);
            this.RedFm.TabIndex = 5;
            // 
            // RedEm
            // 
            this.RedEm.Location = new System.Drawing.Point(362, 289);
            this.RedEm.Name = "RedEm";
            this.RedEm.Size = new System.Drawing.Size(100, 23);
            this.RedEm.TabIndex = 6;
            // 
            // RedPass
            // 
            this.RedPass.Location = new System.Drawing.Point(206, 347);
            this.RedPass.Name = "RedPass";
            this.RedPass.Size = new System.Drawing.Size(100, 23);
            this.RedPass.TabIndex = 7;
            // 
            // ResSave
            // 
            this.ResSave.Location = new System.Drawing.Point(565, 388);
            this.ResSave.Name = "ResSave";
            this.ResSave.Size = new System.Drawing.Size(75, 23);
            this.ResSave.TabIndex = 8;
            this.ResSave.Text = "Сохранить";
            this.ResSave.UseVisualStyleBackColor = true;
            this.ResSave.Click += new System.EventHandler(this.ResSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(493, 350);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Новый Пароль";
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ResSave);
            this.Controls.Add(this.RedPass);
            this.Controls.Add(this.RedEm);
            this.Controls.Add(this.RedFm);
            this.Controls.Add(this.RedIm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Profil";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox textBox1;
        private Label label5;
    }
}