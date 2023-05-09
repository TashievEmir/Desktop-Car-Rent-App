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
            FormAddCar formAddCar = new FormAddCar();
            formAddCar.Show();
            this.Hide();
        }

        private void btn_searchCar_Click(object sender, EventArgs e)
        {
            FormSearchCar formSearchCar = new FormSearchCar();
            formSearchCar.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers();
            formUsers.Show();
            this.Hide();
        }
    }
}
