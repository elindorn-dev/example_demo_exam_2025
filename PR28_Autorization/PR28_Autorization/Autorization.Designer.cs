namespace PR28_Autorization
{
    partial class Autorization
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
            this.components = new System.ComponentModel.Container();
            this.autorization_button = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.guest_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.captcha = new System.Windows.Forms.Label();
            this.captcha_label = new System.Windows.Forms.Label();
            this.captcha_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // autorization_button
            // 
            this.autorization_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.autorization_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorization_button.ForeColor = System.Drawing.Color.White;
            this.autorization_button.Location = new System.Drawing.Point(191, 231);
            this.autorization_button.Name = "autorization_button";
            this.autorization_button.Size = new System.Drawing.Size(222, 54);
            this.autorization_button.TabIndex = 1;
            this.autorization_button.Text = "Авторизоваться";
            this.autorization_button.UseVisualStyleBackColor = false;
            this.autorization_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(219, 108);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(217, 33);
            this.loginTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(144, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(131, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(219, 159);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(217, 33);
            this.passwordTextBox.TabIndex = 5;
            // 
            // guest_button
            // 
            this.guest_button.BackColor = System.Drawing.Color.White;
            this.guest_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guest_button.ForeColor = System.Drawing.Color.Black;
            this.guest_button.Location = new System.Drawing.Point(191, 340);
            this.guest_button.Name = "guest_button";
            this.guest_button.Size = new System.Drawing.Size(222, 50);
            this.guest_button.TabIndex = 7;
            this.guest_button.Text = "Войти как гость";
            this.guest_button.UseVisualStyleBackColor = false;
            this.guest_button.Click += new System.EventHandler(this.guest_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(166, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "____________________войти иначе____________________";
            // 
            // captcha
            // 
            this.captcha.AutoSize = true;
            this.captcha.Enabled = false;
            this.captcha.Font = new System.Drawing.Font("Ink Free", 27.75F, ((System.Drawing.FontStyle)((((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captcha.Location = new System.Drawing.Point(252, 162);
            this.captcha.Name = "captcha";
            this.captcha.Size = new System.Drawing.Size(122, 46);
            this.captcha.TabIndex = 9;
            this.captcha.Text = "label4";
            this.captcha.Visible = false;
            // 
            // captcha_label
            // 
            this.captcha_label.AutoSize = true;
            this.captcha_label.Enabled = false;
            this.captcha_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captcha_label.Location = new System.Drawing.Point(131, 111);
            this.captcha_label.Name = "captcha_label";
            this.captcha_label.Size = new System.Drawing.Size(149, 25);
            this.captcha_label.TabIndex = 10;
            this.captcha_label.Text = "Введите каптчу:";
            this.captcha_label.Visible = false;
            // 
            // captcha_textBox
            // 
            this.captcha_textBox.Enabled = false;
            this.captcha_textBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captcha_textBox.Location = new System.Drawing.Point(191, 214);
            this.captcha_textBox.MaxLength = 4;
            this.captcha_textBox.Name = "captcha_textBox";
            this.captcha_textBox.Size = new System.Drawing.Size(217, 33);
            this.captcha_textBox.TabIndex = 11;
            this.captcha_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.captcha_textBox.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(191, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(596, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.captcha_textBox);
            this.Controls.Add(this.captcha_label);
            this.Controls.Add(this.captcha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guest_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.autorization_button);
            this.Name = "Autorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button autorization_button;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button guest_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label captcha;
        private System.Windows.Forms.Label captcha_label;
        private System.Windows.Forms.TextBox captcha_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

