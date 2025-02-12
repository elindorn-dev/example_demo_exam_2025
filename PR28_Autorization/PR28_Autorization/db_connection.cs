using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PR28_Autorization
{
    public static class db_connection
    {
        public static string host { get; set; }
        public static string username { get; set; }
        public static string pwd { get; set; }
        public static string database { get; set; }
        public static string connect_string { get; set; }
        public static bool checkConnection()
        {
            try
            {
                db_connection.connect_string = $"host={host};uid={username};pwd={pwd};database={database}";
                MySqlConnection connect = new MySqlConnection(connect_string);
                connect.Open();
                string query = "SELECT 1";
                MySqlCommand command_sql = new MySqlCommand(query, connect);
                command_sql.ExecuteNonQuery();
                connect.Close();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ошибка подключения");
                //MessageBox.Show($"{connect_string}");
                return false;
            }
        }
        public static bool checkAutorization(string login, string pwd)
        {
            try
            {
                MySqlConnection connect = new MySqlConnection(connect_string);
                connect.Open();
                string query = $"SELECT * FROM user WHERE UserLogin = @login AND UserPassword = @pwd;";
                MySqlCommand command_sql = new MySqlCommand(query, connect);
                command_sql.Parameters.AddWithValue("@login", login);
                command_sql.Parameters.AddWithValue("@pwd", pwd);
                var reader = command_sql.ExecuteReader();
                reader.Read();
                WorkspaceUser.UserID = reader.GetInt32(0);
                WorkspaceUser.UserFio = reader.GetString(1)+" "+ reader.GetString(2) + " " + reader.GetString(3);
                connect.Close();
                return true;
            }
            catch (NullReferenceException err)
            {
                MessageBox.Show($"Ошибка авторизации\n{err}");
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ошибка авторизации\n{err}");
                return false;
            }
        }
        public static DataTable LoadData(string table)
        {
            DataTable dt = new DataTable();
            try
            {
                db_connection.connect_string = $"host={host};uid={username};pwd={pwd};database={database}";
                MySqlConnection con = new MySqlConnection(connect_string);
                con.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM {table};", con);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //MessageBox.Show(connect_string);
            }
            return dt;
        }
    }
}
