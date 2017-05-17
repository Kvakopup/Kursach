using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanyaNewHopev2
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        Form f2 = new Editing();
        private void enter_Click(object sender, EventArgs e)
        {
            if( Password.Text == "rurub")
            {
                this.Hide();
                f2.Show();
                Password.Text = "";
            }
            else
            {
                Password.Text = "";
                MessageBox.Show("Пароль невірний.");
            }
            
        }

      
    }
}
