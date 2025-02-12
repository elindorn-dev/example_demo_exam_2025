
namespace PR28_Autorization
{
    partial class AddEditProduct
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
            this.title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.article = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.manuf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.instock = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maxdisc = new System.Windows.Forms.TextBox();
            this.suppl = new System.Windows.Forms.ComboBox();
            this.addedit_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(483, 19);
            this.title.MaxLength = 100;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(338, 32);
            this.title.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(330, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Описание:";
            // 
            // desc
            // 
            this.desc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.desc.Location = new System.Drawing.Point(125, 260);
            this.desc.MaxLength = 200;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(460, 32);
            this.desc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Категория:";
            // 
            // category
            // 
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(126, 143);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(459, 33);
            this.category.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(66, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Артикул:";
            // 
            // article
            // 
            this.article.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.article.Location = new System.Drawing.Point(151, 19);
            this.article.MaxLength = 6;
            this.article.Name = "article";
            this.article.Size = new System.Drawing.Size(172, 32);
            this.article.TabIndex = 10;
            this.article.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.article_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Производитель:";
            // 
            // manuf
            // 
            this.manuf.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.manuf.Location = new System.Drawing.Point(179, 181);
            this.manuf.MaxLength = 100;
            this.manuf.Name = "manuf";
            this.manuf.Size = new System.Drawing.Size(406, 32);
            this.manuf.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Поставщик:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(236, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ед-ца измерения:";
            // 
            // unit
            // 
            this.unit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unit.Location = new System.Drawing.Point(403, 62);
            this.unit.MaxLength = 50;
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(182, 32);
            this.unit.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(12, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Цена:";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.price.Location = new System.Drawing.Point(82, 217);
            this.price.MaxLength = 7;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(127, 32);
            this.price.TabIndex = 20;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(215, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Скидка:";
            // 
            // discount
            // 
            this.discount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.discount.Location = new System.Drawing.Point(293, 219);
            this.discount.MaxLength = 2;
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(76, 32);
            this.discount.TabIndex = 22;
            this.discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discount_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(12, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Кол-во:";
            // 
            // instock
            // 
            this.instock.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.instock.Location = new System.Drawing.Point(126, 62);
            this.instock.MaxLength = 10;
            this.instock.Name = "instock";
            this.instock.Size = new System.Drawing.Size(96, 32);
            this.instock.TabIndex = 24;
            this.instock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.instock_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(375, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Макс. скидка:";
            // 
            // maxdisc
            // 
            this.maxdisc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxdisc.Location = new System.Drawing.Point(509, 220);
            this.maxdisc.MaxLength = 2;
            this.maxdisc.Name = "maxdisc";
            this.maxdisc.Size = new System.Drawing.Size(74, 32);
            this.maxdisc.TabIndex = 26;
            this.maxdisc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxdisc_KeyPress);
            // 
            // suppl
            // 
            this.suppl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suppl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.suppl.FormattingEnabled = true;
            this.suppl.Location = new System.Drawing.Point(126, 104);
            this.suppl.Name = "suppl";
            this.suppl.Size = new System.Drawing.Size(459, 33);
            this.suppl.TabIndex = 28;
            // 
            // addedit_button
            // 
            this.addedit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addedit_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addedit_button.ForeColor = System.Drawing.Color.White;
            this.addedit_button.Location = new System.Drawing.Point(269, 317);
            this.addedit_button.Name = "addedit_button";
            this.addedit_button.Size = new System.Drawing.Size(316, 50);
            this.addedit_button.TabIndex = 29;
            this.addedit_button.Text = "ДОБАВИТЬ";
            this.addedit_button.UseVisualStyleBackColor = false;
            this.addedit_button.Click += new System.EventHandler(this.guest_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PR28_Autorization.Properties.Resources.clickforadd;
            this.pictureBox1.Location = new System.Drawing.Point(591, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PR28_Autorization.Properties.Resources.back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 377);
            this.Controls.Add(this.addedit_button);
            this.Controls.Add(this.suppl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.maxdisc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.instock);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.manuf);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.article);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(858, 416);
            this.Name = "AddEditProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox article;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox manuf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox unit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox instock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox maxdisc;
        private System.Windows.Forms.ComboBox suppl;
        private System.Windows.Forms.Button addedit_button;
    }
}