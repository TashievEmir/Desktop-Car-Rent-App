using Car_Rent_App.Entities;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormSearchCar : Form
    {
        public FormSearchCar()
        {
            InitializeComponent();
        }

        private void btnAddCars_Click(object sender, EventArgs e)
        {
            FormAddCar formAddCar = new FormAddCar();
            formAddCar.Show();
            this.Hide();
        }

        private void btn_AllCar_Click(object sender, EventArgs e)
        {
            FormAllCars formAllCars = new FormAllCars();
            formAllCars.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers();
            formUsers.Show();
            this.Hide();
        }

        private async void btnserach_Click(object sender, EventArgs e)
        {
            string brand = tbBrand.Text;
            string model = tbmodel.Text;

            if ( brand=="" && model=="" )
            {
                MessageBox.Show("You must fill at least one blank");
            }
            else if (brand=="" && model!="")
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    var cars = await db.Cars.Where(z => z.Model == model && z.isAvailable == true).ToListAsync();
                    dataGVSearchCar.DataSource = cars;
                }
            }
            else if (brand!="" && model=="")
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    var cars = await db.Cars.Where(z => z.Brand == brand && z.isAvailable == true).ToListAsync();
                    dataGVSearchCar.DataSource = cars;
                }
            }
            else
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    var cars = await db.Cars.Where(z =>z.Brand==brand && z.Model == model && z.isAvailable == true).ToListAsync();
                    dataGVSearchCar.DataSource = cars;
                }
            }
        }

        private async void btnBook_Click(object sender, EventArgs e)
        {
            
            if(dataGVSearchCar.SelectedRows.Count > 0)
            {
                var row = dataGVSearchCar.SelectedRows[0];
                Car car = new Car
                {
                    Id = Convert.ToInt32(row.Cells[0].Value),
                    Brand = row.Cells[1].Value.ToString(),
                    Model = row.Cells[2].Value.ToString(),
                    Year = Convert.ToDateTime(row.Cells[3].Value),
                    Color = row.Cells[4].Value.ToString(),
                    Price = Convert.ToInt32(row.Cells[5].Value),
                    isAvailable = Convert.ToBoolean(row.Cells[6].Value)
                };
                using (ApplicationContext db = new ApplicationContext())
                {
                    db.Cars.Update(car);
                    await db.SaveChangesAsync();
                }
                MessageBox.Show("Your booking is accepted");
            }
            else
            {
                MessageBox.Show("you didn't choose the row");
            }
            
        }
    }
}
