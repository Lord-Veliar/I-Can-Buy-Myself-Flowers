namespace Flowers
{
    partial class Rastenia
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
            this.label666 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label666
            // 
            this.label666.AutoSize = true;
            this.label666.Location = new System.Drawing.Point(520, 45);
            this.label666.Name = "label666";
            this.label666.Size = new System.Drawing.Size(48, 15);
            this.label666.TabIndex = 0;
            this.label666.Text = "Ничего";
            // 
            // Rastenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 582);
            this.Controls.Add(this.label666);
            this.Name = "Rastenia";
            this.Text = "Rastenia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label label666;
    }
}