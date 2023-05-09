using Car_Rent_App.Entities;
using ApplicationContext = Car_Rent_App.Entities.ApplicationContext;

namespace Car_Rent_App.Views
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private async void btn_registr_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string surname = tb_surname.Text;
            string email = tb_emailRegistr.Text;
            string phone = tb_phone.Text;
            string password = tb_passw.Text;
            string passwordRepeat = tb_passwRepeat.Text;
            string role = cbrole.Text;

            if(name==null || surname==null || email==null || phone==null || 
                password==null || passwordRepeat==null)
            {
                MessageBox.Show("You must fill all blankes");
            }
            else if (password!=passwordRepeat)
            {
                MessageBox.Show("Your passwords isn't same!");
            }
            else
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    User user = new User
                    {
                        Name = name,
                        Surname = surname,
                        Email = email,
                        Phone = phone,
                        Password = password,
                        Role = role
                    };
                    await db.Users.AddAsync(user);
                    await db.SaveChangesAsync();
                    MessageBox.Show("The user added succesfully");
                    this.Hide();
                    FormAuthentificate formAuthentificate = new FormAuthentificate();
                    formAuthentificate.Show();
                }
            }
        }

        private void cbrole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
