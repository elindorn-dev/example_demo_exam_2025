using System;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;

namespace PR28_Autorization
{
    public partial class ConnectParameters : Form
    {
        public ConnectParameters()
        {
            InitializeComponent();
        }

        private void guest_button_Click(object sender, EventArgs e)
        {
            string host = serverTextBox.Text;
            string database = dbTextBox.Text;
            string username = usernameTextBox.Text;
            string pwd = userpasswordTextBox.Text;

            db_connection.host = host;
            db_connection.database = database;
            db_connection.username = username;
            db_connection.pwd = pwd;
            db_connection.connect_string = $"host={host};uid={username};pwd={pwd};database={database}";

            Configuration config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);

            config.AppSettings.Settings["host"].Value = host;
            config.AppSettings.Settings["db"].Value = database;
            config.AppSettings.Settings["uid"].Value = username;
            config.AppSettings.Settings["pwd"].Value = pwd;

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            if (db_connection.checkConnection())
            {
                Autorization form = new Autorization();
                form.Show();
                this.Hide();
            }
        }

        private void ConnectParameters_Load(object sender, EventArgs e)
        {
            serverTextBox.Text = ConfigurationManager.AppSettings["host"];
            dbTextBox.Text = ConfigurationManager.AppSettings["db"];
            usernameTextBox.Text = ConfigurationManager.AppSettings["uid"];
            userpasswordTextBox.Text = ConfigurationManager.AppSettings["pwd"];
        }

        private void ConnectParameters_FormClosed(object sender, FormClosedEventArgs e)
        {
            Autorization form = new Autorization();
            form.Show();
            this.Hide();
            //Application.Exit();
        }
    }
}
