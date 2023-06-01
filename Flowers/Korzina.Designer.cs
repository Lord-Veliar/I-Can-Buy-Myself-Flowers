namespace Flowers
{
    partial class Korzina
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
            this.oplata = new System.Windows.Forms.Button();
            this.spic = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.summa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oplata
            // 
            this.oplata.Location = new System.Drawing.Point(567, 369);
            this.oplata.Name = "oplata";
            this.oplata.Size = new System.Drawing.Size(75, 23);
            this.oplata.TabIndex = 0;
            this.oplata.Text = "Оплатить";
            this.oplata.UseVisualStyleBackColor = true;
            // 
            // spic
            // 
            this.spic.AutoSize = true;
            this.spic.Location = new System.Drawing.Point(238, 79);
            this.spic.Name = "spic";
            this.spic.Size = new System.Drawing.Size(102, 15);
            this.spic.TabIndex = 1;
            this.spic.Text = "Список растений";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(459, 79);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(38, 15);
            this.cost.TabIndex = 2;
            this.cost.Text = "Цены";
            // 
            // summa
            // 
            this.summa.AutoSize = true;
            this.summa.Location = new System.Drawing.Point(583, 331);
            this.summa.Name = "summa";
            this.summa.Size = new System.Drawing.Size(36, 15);
            this.summa.TabIndex = 3;
            this.summa.Text = "0 руб";
            this.summa.Click += new System.EventHandler(this.summa_Click);
            // 
            // Korzina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.summa);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.spic);
            this.Controls.Add(this.oplata);
            this.Name = "Korzina";
            this.Text = "Korzina";
            this.Load += new System.EventHandler(this.Korzina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button oplata;
        private Label spic;
        private Label cost;
        private Label summa;
    }
}