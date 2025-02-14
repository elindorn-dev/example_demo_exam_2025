using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR28_Autorization
{
    public partial class Product : Form
    {
        private bool placeholder_visible = true;
        int count = 1;
        public Product()
        {
            InitializeComponent();
        }

        DataTable products_table;
        private void LoadProductDataGridView()
        {
            count = Convert.ToInt32(textBox2.Text);
            dataGridView1.Rows.Clear();
            int pages = products_table.Rows.Count / 20 + 1;
            if (count == pages)
            {
                for (int i = (count - 1) * 20; i < count * 20 - (20 - products_table.Rows.Count % 20); i++)
                {
                    DataRow row = products_table.Rows[i];
                    string path_image = "picture.png";
                    Image o;
                    if (row[4].ToString() != "")
                    {
                        path_image = $"Товар_import/{row[4]}";
                    }
                    try
                    {
                        o = new Bitmap($"{path_image}");
                    }
                    catch
                    {
                        o = new Bitmap($"picture.png");
                    }
                    dataGridView1.Rows.Add(o, $"{row[1]}\n{row[2]}\n{row[5]}\n{row[8]}", $"{row[9]}");
                }
            }
            else
            {
                for (int i = (count - 1) * 20; i < count * 20; i++)
                {
                    DataRow row = products_table.Rows[i];
                    Image o;
                    string path_image = "picture.png";
                    if (row[4].ToString() != "")
                    {
                        path_image = $"Товар_import/{row[4]}";
                    }
                    try
                    {
                        o = new Bitmap($"{path_image}");
                    }
                    catch
                    {
                        o = new Bitmap($"picture.png");
                    }
                    dataGridView1.Rows.Add(o, $"{row[1]}\n{row[2]}\n{row[5]}\n{row[8]}", $"{row[9]}");
                }
            }
            //for (int i = 0; i < products_table.Rows.Count;i++)
            //{
            //    DataRow row = products_table.Rows[i];
            //    string path_image = "picture.png";
            //    Image o;
            //    if (row[4].ToString() != "")
            //    {
            //        path_image = $"Товар_import/{row[4]}";
            //    }
            //    try
            //    {
            //        o = new Bitmap($"{path_image}");
            //    }
            //    catch
            //    {
            //        o = new Bitmap($"picture.png");
            //    }
            //    dataGridView1.Rows.Add(o, $"{row[1]}\n{row[2]}\n{row[5]}\n{row[8]}", $"{row[9]}");
            //}
            //foreach (DataRow row in products_table.Rows)
            //{
            //    string path_image = "picture.png";
            //    Image o;
            //    if (row[4].ToString() != "")
            //    {
            //        path_image = $"Товар_import/{row[4]}";
            //    }
            //    try
            //    {
            //        o = new Bitmap($"{path_image}");
            //    }
            //    catch
            //    {
            //        o = new Bitmap($"picture.png");
            //    }
            //    dataGridView1.Rows.Add(o, $"{row[1]}\n{row[2]}\n{row[5]}\n{row[8]}", $"{row[9]}");
            //}
        }

        private void Product_Load(object sender, EventArgs e)
        {
            if (WorkspaceUser.UserMode == "user")
            {
                user_main_label.Text = WorkspaceUser.UserFio;
            }
            else
            {
                user_main_label.Text = DateTime.Now.ToString("dd.MM.yyyy\n«Гостевой режим»");
                contextMenuStrip1.Enabled = false;
                contextMenuStrip1.Visible = false;
            }
            products_table = db_connection.LoadData("Product");
            LoadProductDataGridView();
        }

        private void Product_FormClosed(object sender, FormClosedEventArgs e)
        {
            Autorization form = new Autorization();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorization form = new Autorization();
            form.Show();
            this.Hide();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkspaceUser.AddEditMode = "ADD";
            AddEditProduct form = new AddEditProduct();
            form.Show();
            this.Hide();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index_row = dataGridView1.SelectedCells[0].RowIndex;
            DataRow selected_row = products_table.Rows[index_row];
            WorkspaceUser.AddEditId = Convert.ToString(selected_row[0]);
            WorkspaceUser.AddEditMode = "EDIT";
            AddEditProduct form = new AddEditProduct();
            form.Show();
            this.Hide();
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            //if (placeholder_visible == true)
            //{
            //    searchTextBox.Text = "";
            //    searchTextBox.ForeColor = Color.Black;
            //}

            //placeholder_visible = false;
            
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            searchTextBox.ForeColor = Color.Black;
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                searchTextBox.Text = "Введите для поиска ...";
                searchTextBox.ForeColor = Color.Gray;
                products_table = db_connection.LoadData("Product");
                LoadProductDataGridView();
            }
        }
        private void SortFilter()
        {
            //MessageBox.Show($"{comboBox1.SelectedIndex}");
            dataGridView1.Rows.Clear();
            string method_sort = "ORDER BY ProductCost ASC";
            string method_filter = "";
            string method = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0: method_sort = "ORDER BY ProductCost ASC"; break;
                case 1: method_sort = "ORDER BY ProductCost DESC"; break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 0: method_filter = "WHERE ProductDiscountAmount > 0 AND ProductDiscountAmount < 10"; break;
                case 1: method_filter = "WHERE ProductDiscountAmount > 10 AND ProductDiscountAmount < 15"; break;
                case 2: method_filter = "WHERE ProductDiscountAmount > 15"; break;
            }
            method = $"product {method_filter} {method_sort}";
            products_table = db_connection.LoadData(method);
            if (products_table.Rows.Count != 0)
            {
                LoadProductDataGridView();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortFilter();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortFilter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pages = products_table.Rows.Count / 20 + 1;
            if (pages > count)
            {
                count++;
                textBox2.Text = $"{count}";
                LoadProductDataGridView();
            }
            
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string method = $"product WHERE ProductName LIKE '%{searchTextBox.Text}%';";

            products_table = db_connection.LoadData(method);
            LoadProductDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pages = products_table.Rows.Count / 20 + 1;
            if (count > 1)
            {
                count--;
                textBox2.Text = $"{count}";
                LoadProductDataGridView();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Zakaz form = new Zakaz();
            form.Show();
            this.Hide();
        }
    }
}
