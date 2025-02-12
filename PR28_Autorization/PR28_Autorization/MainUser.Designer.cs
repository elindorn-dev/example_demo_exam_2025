namespace PR28_Autorization
{
    partial class MainUser
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
            this.guest_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guest_button
            // 
            this.guest_button.BackColor = System.Drawing.Color.White;
            this.guest_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guest_button.ForeColor = System.Drawing.Color.Black;
            this.guest_button.Location = new System.Drawing.Point(123, 62);
            this.guest_button.Name = "guest_button";
            this.guest_button.Size = new System.Drawing.Size(222, 50);
            this.guest_button.TabIndex = 8;
            this.guest_button.Text = "Товары";
            this.guest_button.UseVisualStyleBackColor = false;
            this.guest_button.Click += new System.EventHandler(this.guest_button_Click);
            // 
            // MainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guest_button);
            this.Name = "MainUser";
            this.Text = "MainUser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button guest_button;
    }
}