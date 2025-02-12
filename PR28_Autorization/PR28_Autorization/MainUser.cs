using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR28_Autorization
{
    public partial class MainUser : Form
    {
        public MainUser()
        {
            InitializeComponent();
        }

        private void guest_button_Click(object sender, EventArgs e)
        {
            Product form = new Product();
            form.Show();
            this.Hide();
        }
    }
}
