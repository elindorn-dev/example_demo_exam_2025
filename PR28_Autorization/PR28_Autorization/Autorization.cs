using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PR28_Autorization
{
    public partial class Autorization : Form
    {
        private int counter = 0;
        public Autorization()
        {
            InitializeComponent();
        }
        private string TextGenerate()
        {
            Random random = new Random();
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string result = "";
            for (int i = 0; i<4;i++)
            {
                result += Convert.ToString(chars[random.Next(0, chars.Length-1)]);
            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db_connection.host = ConfigurationManager.AppSettings["host"];
            db_connection.database = ConfigurationManager.AppSettings["db"];
            db_connection.username = ConfigurationManager.AppSettings["uid"];
            db_connection.pwd = ConfigurationManager.AppSettings["pwd"];
            captcha.Text = TextGenerate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string pwd = passwordTextBox.Text;
            if (!db_connection.checkConnection())
            {
                ConnectParameters form = new ConnectParameters();
                form.Show();
                this.Hide();
            }
            else
            {
                if (login == "admin" && pwd == "admin")
                {
                    WorkspaceUser.UserMode = "user";
                    MainAdmin form = new MainAdmin();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    if (db_connection.checkAutorization(login, pwd))
                    {
                        if (WorkspaceUser.UserID != 0)
                        {
                            WorkspaceUser.UserMode = "user";
                            MainUser form = new MainUser();
                            form.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        captcha.Text = TextGenerate();

                        loginTextBox.Visible = false;
                        passwordTextBox.Visible = false;
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        autorization_button.Visible = false;
                        guest_button.Visible = false;

                        loginTextBox.Enabled = false;
                        passwordTextBox.Enabled = false;
                        label1.Enabled = false;
                        label2.Enabled = false;
                        label3.Enabled = false;
                        autorization_button.Enabled = false;
                        guest_button.Enabled = false;

                        captcha_label.Visible = true;
                        captcha.Visible = true;
                        captcha_textBox.Visible = true;
                        button1.Visible = true;

                        captcha_label.Enabled = true;
                        captcha.Enabled = true;
                        captcha_textBox.Enabled = true;
                        button1.Enabled = true;
                    }
                }
            }
        }

        private void guest_button_Click(object sender, EventArgs e)
        {
            if (!db_connection.checkConnection())
            {
                ConnectParameters form = new ConnectParameters();
                form.Show();
                this.Hide();
            }
            else
            {
                WorkspaceUser.UserMode = "guest";

                Product form = new Product();
                form.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (captcha_textBox.Text == captcha.Text)
            {
                loginTextBox.Visible = true;
                passwordTextBox.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                autorization_button.Visible = true;
                guest_button.Visible = true;

                loginTextBox.Enabled = true;
                passwordTextBox.Enabled = true;
                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                autorization_button.Enabled = true;
                guest_button.Enabled = true;

                captcha_label.Visible = false;
                captcha.Visible = false;
                captcha_textBox.Visible = false;
                button1.Visible = false;

                captcha_label.Enabled = false;
                captcha.Enabled = false;
                captcha_textBox.Enabled = false;
                button1.Enabled = false;

                captcha_textBox.Text = "";
            }
            else
            {
                button1.Enabled = false;
                MessageBox.Show("Неверный ввод каптчи");
                captcha.Text = TextGenerate();
                captcha_textBox.Text = "";
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter > 10)
            {
                button1.Enabled = true;
                timer1.Stop();
                counter = 0;
            }
            else
            {
                counter++;
            }
        }
    }
}
