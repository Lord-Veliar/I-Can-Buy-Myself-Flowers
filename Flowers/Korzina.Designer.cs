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
            oplata = new Button();
            spic = new Label();
            cost = new Label();
            summa = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // oplata
            // 
            oplata.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            oplata.BackColor = Color.FromArgb(142, 213, 228);
            oplata.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            oplata.Location = new Point(921, 271);
            oplata.Name = "oplata";
            oplata.Size = new Size(131, 40);
            oplata.TabIndex = 0;
            oplata.Text = "Оплатить";
            oplata.UseVisualStyleBackColor = false;
            oplata.Click += oplata_Click;
            // 
            // spic
            // 
            spic.Anchor = AnchorStyles.Top;
            spic.AutoSize = true;
            spic.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            spic.Location = new Point(49, 145);
            spic.Name = "spic";
            spic.Size = new Size(229, 37);
            spic.TabIndex = 1;
            spic.Text = "Список растений";
            // 
            // cost
            // 
            cost.Anchor = AnchorStyles.Top;
            cost.AutoSize = true;
            cost.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            cost.Location = new Point(675, 145);
            cost.Name = "cost";
            cost.Size = new Size(92, 40);
            cost.TabIndex = 2;
            cost.Text = "Цены";
            // 
            // summa
            // 
            summa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            summa.AutoSize = true;
            summa.BackColor = Color.FromArgb(253, 236, 255);
            summa.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            summa.Location = new Point(921, 224);
            summa.Name = "summa";
            summa.Size = new Size(24, 30);
            summa.TabIndex = 3;
            summa.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(197, 235, 207);
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1164, 108);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(0, 64, 0);
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(197, 235, 207);
            linkLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(1019, 38);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(114, 32);
            linkLabel1.TabIndex = 47;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Профиль";
            linkLabel1.VisitedLinkColor = Color.Black;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.FromArgb(0, 64, 0);
            linkLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.FromArgb(197, 235, 207);
            linkLabel2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(849, 38);
            linkLabel2.Margin = new Padding(2, 0, 2, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(107, 32);
            linkLabel2.TabIndex = 46;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Корзина";
            linkLabel2.VisitedLinkColor = Color.Black;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(197, 235, 207);
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 24);
            label1.Name = "label1";
            label1.Size = new Size(218, 65);
            label1.TabIndex = 49;
            label1.Text = "Корзина";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(253, 236, 255);
            pictureBox2.Location = new Point(813, 104);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(350, 233);
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(253, 236, 255);
            label2.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(921, 141);
            label2.Name = "label2";
            label2.Size = new Size(102, 41);
            label2.TabIndex = 51;
            label2.Text = "Итого";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(253, 236, 255);
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1000, 224);
            label3.Name = "label3";
            label3.Size = new Size(52, 30);
            label3.TabIndex = 52;
            label3.Text = "руб.";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(142, 213, 228);
            pictureBox4.Location = new Point(12, 67);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 10);
            pictureBox4.TabIndex = 55;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(142, 213, 228);
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Location = new Point(12, 50);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 11);
            pictureBox3.TabIndex = 54;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(142, 213, 228);
            pictureBox5.Location = new Point(12, 33);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 10);
            pictureBox5.TabIndex = 53;
            pictureBox5.TabStop = false;
            // 
            // Korzina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1163, 530);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(linkLabel2);
            Controls.Add(summa);
            Controls.Add(cost);
            Controls.Add(spic);
            Controls.Add(oplata);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Korzina";
            Text = "Korzina";
            Load += Korzina_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button oplata;
        private Label spic;
        private Label cost;
        private Label summa;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
    }
}