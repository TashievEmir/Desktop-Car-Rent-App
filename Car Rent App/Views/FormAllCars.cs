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
                var cars = db.Cars.Where(x => x.isAvailable==true);
                dataGV_allCars.DataSource = cars.ToList();
            }
        }

        private void btnAddCars_Click(object sender, EventArgs e)
        {
            FormAddCar formAddCar = new FormAddCar();
            formAddCar.Show();
            this.Hide();
        }
    }
}
