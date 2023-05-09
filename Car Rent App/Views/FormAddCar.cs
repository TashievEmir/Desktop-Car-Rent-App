using Car_Rent_App.Entities;
using ApplicationContext = Car_Rent_App.Entities.ApplicationContext;

namespace Car_Rent_App.Views
{
    public partial class FormAddCar : Form
    {
        public FormAddCar()
        {
            InitializeComponent();
        }

        private void lb_AddCar_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string brand = tb_brand.Text;
            string model = tb_Model.Text;
            string year = dateTimePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd");
            string color = tbColor.Text;
            int price = Convert.ToInt32(tbPrice.Text);
            bool availability = true;

            using (ApplicationContext db = new ApplicationContext())
            {
                Car car = new Car
                {
                    Brand= brand,
                    Model= model,
                    Year= Convert.ToDateTime(year).ToUniversalTime(),
                    Color= color,
                    Price= price,
                    isAvailable= availability
                };
                await db.Cars.AddAsync(car);
                await db.SaveChangesAsync();
                MessageBox.Show("The car has added");
            }
            this.Refresh();
        }

        private void btnAllCars_Click(object sender, EventArgs e)
        {
            FormAllCars formAllCars = new FormAllCars();
            formAllCars.Show();
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
