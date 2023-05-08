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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAuthentificate formAuthentificate = new FormAuthentificate();
            formAuthentificate.Show();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            FormAddCar formAddCar = new FormAddCar();
            formAddCar.Show();
            this.Hide();
        }

        private void btnAllCars_Click(object sender, EventArgs e)
        {
            FormAllCars formAllCars = new FormAllCars();
            formAllCars.Show();
            this.Hide();
        }
    }
}
