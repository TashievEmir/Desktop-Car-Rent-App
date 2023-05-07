using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rent_App.Views
{
    public partial class FormAuthentificate : Form
    {
        public FormAuthentificate()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.ShowDialog();
        }

        private void tbemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email=tbemail.Text;
            string password = tbpassword.Text;

        }
    }
}
