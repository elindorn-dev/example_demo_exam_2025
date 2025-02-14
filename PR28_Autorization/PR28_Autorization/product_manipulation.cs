using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PR28_Autorization
{
    static public class product_manipulation
    {
        public static bool insertProduct(string article, string title, string desc, string category, string image_name, string manufact, string supplier, string unit, string cost, string discount, string instock, string maxdiscount)
        {
            try
            {
                string s_c = $"host={db_connection.host};uid={db_connection.username};pwd={db_connection.pwd};database={db_connection.database}";
                MySqlConnection connect = new MySqlConnection(s_c);
                connect.Open();
                string query = $"SELECT ProductArticleNumber FROM `db47`.`product` WHERE `product`.`ProductArticleNumber` = '{article}';";
                MySqlCommand command_sql = new MySqlCommand(query, connect);
                int exist_article = Convert.ToInt32(command_sql.ExecuteScalar());
                if (exist_article > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Запись с таким артикулом уже существует.\nЗаменить запись?", "Внимание!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query_change_row = $@"DELETE FROM `db47`.`product` WHERE `product`.`ProductArticleNumber` = '{article}';";
                        command_sql.CommandText = query_change_row;
                        command_sql.ExecuteNonQuery();
                        query_change_row = $@"INSERT INTO `db47`.`product` (`ProductArticleNumber`, `ProductName`, `ProductDescription`, `ProductCategory`, `ProductPhoto`, `ProductManufacturer`, `ProductSupplier`, `ProductUnit`, `ProductCost`, `ProductDiscountAmount`, `ProductQuantityInStock`, `ProductDiscountMax`) 
                        VALUES 
                        ('{article}', '{title}', '{desc}', '{category}', '{image_name}', '{manufact}', '{supplier}', '{unit}', '{cost}', '{discount}', '{instock}', '{maxdiscount}');";
                        command_sql.CommandText = query_change_row;
                        command_sql.ExecuteNonQuery();
                    }
                    else {
                        return false;
                    }
                }
                else
                {
                    string query_change_row = $@"INSERT INTO `db47`.`product` (`ProductArticleNumber`, `ProductName`, `ProductDescription`, `ProductCategory`, `ProductPhoto`, `ProductManufacturer`, `ProductSupplier`, `ProductUnit`, `ProductCost`, `ProductDiscountAmount`, `ProductQuantityInStock`, `ProductDiscountMax`) 
                        VALUES 
                        ('{article}', '{title}', '{desc}', '{category}', '{image_name}', '{manufact}', '{supplier}', '{unit}', '{cost}', '{discount}', '{instock}', '{maxdiscount}');";
                    command_sql.CommandText = query_change_row;
                    command_sql.ExecuteNonQuery();
                }
                connect.Close();
                
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ошибка добавления\n{err.Message}");
                //MessageBox.Show($"{connect_string}");
                return false;
            }
        }
        public static bool editProduct(string article, string title, string desc, string category, string image_name, string manufact, string supplier, string unit, string cost, string discount, string instock, string maxdiscount)
        {
            try
            {
                string s_c = $"host={db_connection.host};uid={db_connection.username};pwd={db_connection.pwd};database={db_connection.database}";
                MySqlConnection connect = new MySqlConnection(s_c);
                connect.Open();
                string query = $@"UPDATE `db47`.`product` SET  
`ProductName` = '{title}', 
`ProductDescription` = '{desc}', 
`ProductCategory` = '{category}', 
`ProductPhoto` = '{image_name}', 
`ProductManufacturer` = '{manufact}', 
`ProductSupplier` = '{supplier}',
`ProductUnit` = '{unit}', 
`ProductCost` = '{cost}', 
`ProductDiscountAmount` = '{discount}', 
`ProductQuantityInStock` = '{instock}', 
`ProductDiscountMax` = '{maxdiscount}' 
WHERE (`ProductArticleNumber` = '{article}');";
                
                MySqlCommand command_sql = new MySqlCommand(query, connect);

                command_sql.ExecuteNonQuery();
                    
                connect.Close();

                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ошибка добавления\n{err.Message}");
                //MessageBox.Show($"{connect_string}");
                return false;
            }
        }
    }
}
