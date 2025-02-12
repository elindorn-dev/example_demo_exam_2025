using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace PR28_Autorization
{
    public partial class MainAdmin : Form
    {
        private int timer_counter = 0;
        public MainAdmin()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();

            if (WorkspaceUser.UserMode == "user")
            {
                user_main_label.Text = WorkspaceUser.UserFio;
            }
            else
            {
                user_main_label.Text = DateTime.Now.ToString("dd.MM.yyyy\n«Гостевой режим»");
            }

            string[] tables_names = { "category", "order", "orderproduct", "pickuppoint", "product", "role", "status", "supplier", "user" };
            comboBox1.DataSource = tables_names;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Autorization form = new Autorization();
            form.Show();
            this.Hide();
        }

        private void guest_button_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection($"host={db_connection.host};uid={db_connection.username};pwd={db_connection.pwd};");
            connect.Open();
            string path = "structure_dump.sql";
            string text_script = "";
            if (File.Exists(path))
            {
                text_script = File.ReadAllText(path);
            }
            //MessageBox.Show($"{text_script}");
            string[] sql_commands = text_script.Split(';');
            string text = "";
            try
            {
                for (int i = 0; i < sql_commands.Length; i++)
                {
                    sql_commands[i] += ";";
                    MySqlCommand cmd = new MySqlCommand(sql_commands[i], connect);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Структура восстановлена");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message); 
            }
            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query_category = "INSERT INTO `db47`.`category` (`CategoryID`, `CategoryTitle`) VALUES (";
            string query_order = "INSERT INTO `db47`.`order` (`OrderID`, `OrderOpenDate`, `OrderStatus`, `OrderDeliveryDate`, `OrderPickupPoint`, `OrderClient`, `OrderCode`) VALUES (";
            string query_orderproduct = "INSERT INTO `db47`.`orderproduct` (`OrderID`, `ProductArticleNumber`, `Amount`) VALUES (";
            string query_pickuppoint = "INSERT INTO `db47`.`pickuppoint` (`PickupPointID`, `PickupPointAddress`) VALUES (";
            string query_product = "INSERT INTO `db47`.`product` (`ProductArticleNumber`, `ProductName`, `ProductDescription`, `ProductCategory`, `ProductPhoto`, `ProductManufacturer`, `ProductSupplier`, `ProductUnit`, `ProductCost`, `ProductDiscountAmount`, `ProductQuantityInStock`, `ProductDiscountMax`) VALUES (";
            string query_role = "INSERT INTO `db47`.`role` (`RoleID`, `RoleName`) VALUES (";
            string query_status = "INSERT INTO `db47`.`status` (`StatusID`, `StatusTitle`) VALUES (";
            string query_supplier = "INSERT INTO `db47`.`supplier` (`SupplierID`, `SupplierName`, `SupplierDescription`) VALUES (";
            string query_user = "INSERT INTO `db47`.`user` (`UserID`, `UserSurname`, `UserName`, `UserPatronymic`, `UserLogin`, `UserPassword`, `UserRole`) VALUES (";

            string path = "";
            try
            {
                openFileDialog1.Filter = "Files|*.csv";
                openFileDialog1.ShowDialog();
                path = openFileDialog1.FileName;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка при выборе файла csv");
            }
            MySqlConnection connect = new MySqlConnection(db_connection.connect_string);
            connect.Open();
            StreamReader f = new StreamReader(path);
            string query = "";
            switch (comboBox1.Text)
            {
                case "category": query = query_category;  break;
                case "order": query = query_order; break;
                case "orderproduct": query = query_orderproduct; break;
                case "pickuppoint": query = query_pickuppoint; break;
                case "product": query = query_product; break;
                case "role": query = query_role; break;
                case "status": query = query_status; break;
                case "supplier": query = query_supplier; break;
                case "user": query = query_user; break;
            }
            if (!f.EndOfStream)
            {
                f.ReadLine();
            }
            int bad_count = 0;
            int main_count = 0;
            while (!f.EndOfStream)
            { 
                string s = f.ReadLine();
                string[] arr = s.Split(',');
                string query_custom = query;
                for (int i = 0; i<arr.Length-1; i++)
                {
                    query += "'" + arr[i] + "', ";
                }
                query += "'" + arr[arr.Length - 1] + "');";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    //MessageBox.Show($"query: {query}\nlength: {arr.Length}");
                    bad_count++;
                }
                query = query_custom;
                main_count++;
            }
            f.Close();
            connect.Close();

            MessageBox.Show($"Импорт завершился\nУспешно: {main_count-bad_count}\nПропущено: {bad_count}");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_counter++;

            if (timer_counter >= 30)
            {
                timer1.Stop();
                Autorization form = new Autorization();
                form.Show();
                this.Hide();
            }
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            timer_counter = 0;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            timer_counter = 0;
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer_counter = 0;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            timer_counter = 0;
        }
    }
}
