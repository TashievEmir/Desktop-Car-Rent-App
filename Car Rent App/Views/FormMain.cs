using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Rent_App.Views;
namespace Car_Rent_App.Views
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SharedData._authorization.Remove("role");
            FormAuthentificate formAuthentificate = new FormAuthentificate();
            formAuthentificate.Show();
            this.Hide();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
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
    }
}
