namespace Flowers
{
    partial class Avtoriz
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AMeil = new System.Windows.Forms.TextBox();
            this.APass = new System.Windows.Forms.TextBox();
            this.ABut = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Flowers.Properties.Resources.logt;
            this.pictureBox1.Location = new System.Drawing.Point(595, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 133);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(520, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 62);
            this.label2.TabIndex = 3;
            this.label2.Text = "Авторизация";
            // 
            // AMeil
            // 
            this.AMeil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AMeil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AMeil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AMeil.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AMeil.Location = new System.Drawing.Point(559, 269);
            this.AMeil.Name = "AMeil";
            this.AMeil.Size = new System.Drawing.Size(211, 23);
            this.AMeil.TabIndex = 4;
            this.AMeil.Text = "Email";
            this.AMeil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AMeil.TextChanged += new System.EventHandler(this.AMeil_TextChanged);
            this.AMeil.Enter += new System.EventHandler(this.AMeil_Enter);
            this.AMeil.Leave += new System.EventHandler(this.AMeil_Leave);
            // 
            // APass
            // 
            this.APass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.APass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.APass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.APass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.APass.Location = new System.Drawing.Point(559, 326);
            this.APass.Name = "APass";
            this.APass.Size = new System.Drawing.Size(211, 23);
            this.APass.TabIndex = 5;
            this.APass.Text = "Пароль";
            this.APass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.APass.TextChanged += new System.EventHandler(this.APass_TextChanged);
            this.APass.Enter += new System.EventHandler(this.APass_Enter);
            this.APass.Leave += new System.EventHandler(this.APass_Leave);
            // 
            // ABut
            // 
            this.ABut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ABut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(213)))), ((int)(((byte)(228)))));
            this.ABut.Location = new System.Drawing.Point(595, 377);
            this.ABut.Name = "ABut";
            this.ABut.Size = new System.Drawing.Size(142, 33);
            this.ABut.TabIndex = 6;
            this.ABut.Text = "Войти";
            this.ABut.UseVisualStyleBackColor = false;
            this.ABut.Click += new System.EventHandler(this.Vhod_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(616, 427);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 21);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Регистрация";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Avtoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 752);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ABut);
            this.Controls.Add(this.APass);
            this.Controls.Add(this.AMeil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Avtoriz";
            this.Text = "Avtoriz";
            this.Enter += new System.EventHandler(this.AMeil_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox AMeil;
        private TextBox APass;
        private Button ABut;
        private LinkLabel linkLabel1;
    }
}