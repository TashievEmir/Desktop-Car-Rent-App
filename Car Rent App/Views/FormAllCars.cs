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
    public partial class FormAllCars : Form
    {
        public FormAllCars()
        {
            InitializeComponent();

            using (ApplicationContext db = new ApplicationContext())
            {
                var cars = db.Cars.ToList();
                dataGV_allCars.DataSource = cars;
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

        private void btn_searchCar_Click(object sender, EventArgs e)
        {
            FormSearchCar formSearchCar = new FormSearchCar();
            formSearchCar.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (SharedData._authorization["role"] == "admin")
            {
                FormUsers formUsers = new FormUsers();
                formUsers.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You don't have a permission");
            }
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
