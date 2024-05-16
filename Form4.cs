using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ges_scolaire
{
    public partial class Form4 : Form
    {
        gesscolaireEntities1 context = new gesscolaireEntities1();
        public Form4()
        {
            InitializeComponent();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string Username = txtusername.Text;
            string Password = txtpassword.Text;
            var user = context.users.FirstOrDefault(u => u.login == Username && u.password == Password);
            if (user != null)
            {
                Form3 form3 = new Form3();
                form3.Show();
                //this.Hide();
            }
        }

    }
}
