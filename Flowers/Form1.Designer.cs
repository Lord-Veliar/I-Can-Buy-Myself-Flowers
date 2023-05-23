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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameText.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.NameText.Location = new System.Drawing.Point(646, 242);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 23);
            this.NameText.TabIndex = 2;
            this.NameText.Text = "Имя";
            this.NameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameText.Enter += new System.EventHandler(this.NameText_Enter);
            this.NameText.Leave += new System.EventHandler(this.NameText_Leave);
            // 
            // FFF
            // 
            this.FFF.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FFF.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FFF.Location = new System.Drawing.Point(646, 297);
            this.FFF.Name = "FFF";
            this.FFF.Size = new System.Drawing.Size(100, 23);
            this.FFF.TabIndex = 3;
            this.FFF.Text = "Фамилия";
            this.FFF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FFF.Enter += new System.EventHandler(this.FFF_Enter);
            this.FFF.Leave += new System.EventHandler(this.FFF_Leave);
            // 
            // I_Can_Buy_Myself_Flowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 590);
            this.Controls.Add(this.FFF);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "I_Can_Buy_Myself_Flowers";
            this.Text = "I Can Buy Myself Flowers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        public TextBox NameText;
        public TextBox FFF;
    }
}