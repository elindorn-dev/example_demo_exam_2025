using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace PR28_Autorization
{
    public partial class AddEditProduct : Form
    {
        DataTable categories = db_connection.LoadData("category");
        DataTable supplier = db_connection.LoadData("supplier");
        string path = "";
        public AddEditProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product form = new Product();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string file_name = "";
            try
            {
                openFileDialog1.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
                openFileDialog1.ShowDialog();
                path = openFileDialog1.FileName;
                file_name = Path.GetFileName(path);

            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка при выборе файла");
            }
            try
            {
                pictureBox1.Image = Image.FromFile(path);
                //File.Copy(path, $"Товар_import/{file_name}");
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка при обработку картинки");
            }
        }

        private void guest_button_Click(object sender, EventArgs e)
        {
            string artic = article.Text;
            string titl = title.Text;
            string des = desc.Text;
            string categor = category.Text;
            string image_name = Path.GetFileName(path);
            string man = manuf.Text;
            string sup = suppl.Text;
            string uni = unit.Text;
            string cost = price.Text;
            string disco = discount.Text;
            string insklad = instock.Text;
            string maxdisco = maxdisc.Text;
            foreach (DataRow row in categories.Rows)
            {
                if (row["CategoryTitle"].ToString().Equals(categor, StringComparison.Ordinal))
                {
                    categor = row["CategoryID"].ToString();
                    break;
                }
            }
            foreach (DataRow row in supplier.Rows)
            {
                if (row["SupplierName"].ToString().Equals(sup, StringComparison.Ordinal))
                {
                    sup = row["SupplierID"].ToString();
                    break;
                }
            }
            
            if (WorkspaceUser.AddEditMode == "ADD")
            {
                if (article.Text.Length == 6)
                {
                bool result_query = product_manipulation.insertProduct(artic, titl, des, categor, image_name, man, sup, uni, cost, disco, insklad, maxdisco);
                if (result_query) { MessageBox.Show("Товар добавлен."); File.Copy(path, $"Товар_import/{Path.GetFileName(path)}"); }
                else { MessageBox.Show("Товар не был добавлен!"); }
                }
            }
            else
            {
                article.Enabled = false;
                bool result_query = product_manipulation.editProduct(artic, titl, des, categor, image_name, man, sup, uni, cost, disco, insklad, maxdisco);
                if (result_query) { MessageBox.Show("Товар изменен."); File.Copy(path, $"Товар_import/{Path.GetFileName(path)}"); }
                else { MessageBox.Show("Товар не был изменен!"); }
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            switch (WorkspaceUser.AddEditMode)
            {
                case "ADD": addedit_button.Text = "Добавить"; break;
                case "EDIT":
                    article.Enabled = false;
                    addedit_button.Text = "Редактировать";
                    List<string> product_values = new List<string>();
                    string method = $"product WHERE ProductArticleNumber = '{WorkspaceUser.AddEditId}'";
                    DataTable selected_product = db_connection.LoadData(method);
                    DataRow row = selected_product.Rows[0];
                    for (int i = 0; i<12; i++)
                    {
                        product_values.Add(Convert.ToString(row[i]));
                    }
                    article.Text = product_values[0];
                    title.Text = product_values[1];
                    desc.Text = product_values[2];
                    category.Text = product_values[3];
                    try
                    {
                        pictureBox1.Image = new Bitmap($"Товар_import/{product_values[4]}");
                    }
                    catch
                    {
                        pictureBox1.Image = new Bitmap("picture.png");
                    }
                    manuf.Text = product_values[5];
                    suppl.Text = product_values[6];
                    unit.Text = product_values[7];
                    price.Text = product_values[8];
                    discount.Text = product_values[9];
                    instock.Text = product_values[10];
                    maxdisc.Text = product_values[11];
                    break;
            }
            category.DataSource = categories;
            category.DisplayMember = "CategoryTitle";
            suppl.DataSource = supplier;
            suppl.DisplayMember = "SupplierName";
        }
        private void instock_KeyPress(object sender, KeyPressEventArgs e)
        {
            char current_char = e.KeyChar;
            if (!Char.IsDigit(current_char) && current_char != 8)
            {
                e.Handled = true;
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char current_char = e.KeyChar;
            if (!Char.IsDigit(current_char) && current_char != 8)
            {
                e.Handled = true;
            }
        }

        private void discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char current_char = e.KeyChar;
            if (!Char.IsDigit(current_char) && current_char != 8)
            {
                e.Handled = true;
            }
        }

        private void maxdisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char current_char = e.KeyChar;
            if (!Char.IsDigit(current_char) && current_char != 8)
            {
                e.Handled = true;
            }
        }

        private void article_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void article_TextChanged(object sender, EventArgs e)
        {
            if (article.Text.Length != 6)
            {
                article.BackColor = Color.FromArgb(255, 192, 192);
            }
            else
            {
                article.BackColor = Color.White;
            }
        }
    }
}
