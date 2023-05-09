
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ApplicationContext = Car_Rent_App.Entities.ApplicationContext;

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
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.ShowDialog();
            this.Hide();
        }

        private void tbemail_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            string email=tbemail.Text;
            string password = tbpassword.Text;

            using (ApplicationContext db = new ApplicationContext())
            {
                var user = await db.Users.FirstOrDefaultAsync(x => x.Email==email);
                if (user == null)
                {
                    MessageBox.Show("There is no user with such email");
                }
                else if(password != user.Password)
                {
                    MessageBox.Show("Incorrect password");
                }
                else
                {
                    SharedData._authorization.Add("role", $"{user.Role}");

                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Hide();
                }
            }
        }
    }
}
