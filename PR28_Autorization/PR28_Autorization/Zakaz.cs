using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PR28_Autorization
{
    public partial class Zakaz : Form
    {
        DataTable products_table;

        public Zakaz()
        {
            InitializeComponent();
        }
        private void LoadProductDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (DataRow row in products_table.Rows)
            {
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
                dataGridView1.Rows.Add(o, $"{row[1]}", $"{row[7]}");
            }
        }
        private void Zakaz_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("dd.MM.yyyy"); ;
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(15);
            products_table = db_connection.LoadData("Product");
            LoadProductDataGridView();
            if (WorkspaceUser.UserMode == "user")
            {
                user_main_label.Text = WorkspaceUser.UserFio;
            }
            else
            {
                user_main_label.Text = DateTime.Now.ToString("dd.MM.yyyy\n«Гостевой режим»");
            }
        }
    }
}
