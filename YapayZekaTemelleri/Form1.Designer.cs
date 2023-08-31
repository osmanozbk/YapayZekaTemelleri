namespace YapayZekaTemelleri
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSellPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBuyPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnListen = new System.Windows.Forms.Button();
            this.BtnSpeak = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtCategory);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtSellPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtBuyPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtStock);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtMark);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 672);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Active",
            "Passive"});
            this.comboBox1.Location = new System.Drawing.Point(98, 411);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 33);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.BackColorChanged += new System.EventHandler(this.comboBox1_BackColorChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(98, 364);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(203, 31);
            this.maskedTextBox1.TabIndex = 18;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.BackColorChanged += new System.EventHandler(this.maskedTextBox1_BackColorChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 411);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Case:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 367);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 323);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Category:";
            // 
            // TxtCategory
            // 
            this.TxtCategory.Location = new System.Drawing.Point(98, 320);
            this.TxtCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCategory.Name = "TxtCategory";
            this.TxtCategory.Size = new System.Drawing.Size(203, 31);
            this.TxtCategory.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sell Price:";
            // 
            // TxtSellPrice
            // 
            this.TxtSellPrice.Location = new System.Drawing.Point(98, 276);
            this.TxtSellPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSellPrice.Name = "TxtSellPrice";
            this.TxtSellPrice.Size = new System.Drawing.Size(203, 31);
            this.TxtSellPrice.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buy Price:";
            // 
            // TxtBuyPrice
            // 
            this.TxtBuyPrice.Location = new System.Drawing.Point(98, 233);
            this.TxtBuyPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBuyPrice.Name = "TxtBuyPrice";
            this.TxtBuyPrice.Size = new System.Drawing.Size(203, 31);
            this.TxtBuyPrice.TabIndex = 8;
            this.TxtBuyPrice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stock:";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(98, 189);
            this.TxtStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(203, 31);
            this.TxtStock.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Brand:";
            // 
            // TxtMark
            // 
            this.TxtMark.Location = new System.Drawing.Point(98, 145);
            this.TxtMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMark.Name = "TxtMark";
            this.TxtMark.Size = new System.Drawing.Size(203, 31);
            this.TxtMark.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(99, 101);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(203, 31);
            this.TxtName.TabIndex = 2;
            this.TxtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = " PRODUCT DETAILS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnListen);
            this.panel2.Controls.Add(this.BtnSpeak);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(349, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 109);
            this.panel2.TabIndex = 1;
            // 
            // BtnListen
            // 
            this.BtnListen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnListen.Location = new System.Drawing.Point(802, 24);
            this.BtnListen.Name = "BtnListen";
            this.BtnListen.Size = new System.Drawing.Size(153, 47);
            this.BtnListen.TabIndex = 5;
            this.BtnListen.Text = "Litsen";
            this.BtnListen.UseVisualStyleBackColor = false;
            this.BtnListen.Click += new System.EventHandler(this.BtnListen_Click);
            // 
            // BtnSpeak
            // 
            this.BtnSpeak.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSpeak.Location = new System.Drawing.Point(643, 24);
            this.BtnSpeak.Name = "BtnSpeak";
            this.BtnSpeak.Size = new System.Drawing.Size(153, 47);
            this.BtnSpeak.TabIndex = 4;
            this.BtnSpeak.Text = "Speak";
            this.BtnSpeak.UseVisualStyleBackColor = false;
            this.BtnSpeak.Click += new System.EventHandler(this.BtnSpeak_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(484, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Object Detection";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(325, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 47);
            this.button4.TabIndex = 2;
            this.button4.Text = "Image";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Camera Feel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Prodact Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(349, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1077, 198);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1077, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(349, 485);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1077, 187);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.richTextBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(349, 307);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1077, 178);
            this.panel5.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(479, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Please Wait...";
            this.label10.TextChanged += new System.EventHandler(this.label10_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(455, 166);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 672);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSellPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBuyPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnSpeak;
        private System.Windows.Forms.Button BtnListen;
    }
}

