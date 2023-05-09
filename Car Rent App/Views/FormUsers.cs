using Car_Rent_App.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationContext = Car_Rent_App.Entities.ApplicationContext;

namespace Car_Rent_App.Views
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();

            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                dataGV_users.DataSource = users;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGV_users.SelectedRows.Count > 0)
            {
                var row = dataGV_users.SelectedRows[0];
                User user = new User
                {
                    Id = Convert.ToInt32(row.Cells[0].Value),
                    Name = row.Cells[1].Value.ToString(),
                    Surname = row.Cells[2].Value.ToString(),
                    Phone = row.Cells[3].Value.ToString(),
                    Email = row.Cells[4].Value.ToString(),
                    Password = row.Cells[5].Value.ToString(),
                    Role = row.Cells[6].Value.ToString()
                };
                using (ApplicationContext db = new ApplicationContext())
                {
                    db.Users.Update(user);
                    await db.SaveChangesAsync();
                }
                MessageBox.Show("The data updated succesfuly");
            }
            else
            {
                MessageBox.Show("you didn't choose the row");
            }
        }

        private void btnAddCars_Click(object sender, EventArgs e)
        {
            if (SharedData._authorization["role"] == "admin")
            {
                FormAddCar formAddCar = new FormAddCar();
                formAddCar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You don't have a permission");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_AllCar_Click(object sender, EventArgs e)
        {
            FormAllCars formAllCars = new FormAllCars();
            formAllCars.Show();
            this.Hide();
        }

        private void btnSearchCar_Click(object sender, EventArgs e)
        {
            FormSearchCar formSearchCar = new FormSearchCar();
            formSearchCar.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SharedData._authorization.Remove("role");
            FormAuthentificate formAuthentificate = new FormAuthentificate();
            formAuthentificate.Show();
            this.Hide();
        }
    }
}
