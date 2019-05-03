using CarRental.BLL.Concrete;
using CarRental.DAL.Concrete.EntityFramework;
using CarRental.Entities;
using CarRental.WebServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.WinFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string custName = txtCustomerName.Text;
            string custLastName = txtCustomerLastname.Text;
            int carID = Convert.ToInt32(txtcarID.Text);

            RentalInfoService _rentalInfoService = new RentalInfoService();
            CarService _carService = new CarService();
            UserService _userService = new UserService();

            User newUser = new User();
            newUser.email = "-";
            newUser.password = "000";
            newUser.roleID = 3;
            newUser.userName = "new" + custName + custLastName;

            _userService.Add(newUser);


            Car selectedCar = new Car();
            selectedCar = _carService.Get(carID);
            _carService.Update(selectedCar);

            RentalInformation _rentInfo = new RentalInformation();
            _rentInfo.carID = carID;
            _rentInfo.companyID = selectedCar.companyID;
            _rentInfo.rentalDate = DateTime.Now;
            _rentInfo.rentalDay = 3;
            
            _rentalInfoService.Add(_rentInfo);

            List<Car> Cars = _carService.GetAll();

            txtList.Clear();
            foreach (Car car in Cars)
            {
                if (car.rentalStatus == false)
                    txtList.Text += "Car ID: " + car.carID + "  --  Car Name: " + car.CarInformation.carName + "   ////   Car Daily Rental Price: " + car.CarInformation.dailyRentalPrice + " TL  --   Rental Status: " + car.rentalStatus + "\r\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarService _carService = new CarService();

            List<Car> Cars = _carService.GetAll();

            txtList.Clear();
            foreach (Car car in Cars)
            {
                if(car.rentalStatus == false)
                    txtList.Text += "Car ID: " + car.carID + "  --  Car Name: " + car.CarInformation.carName + "   ////   Car Daily Rental Price: " + car.CarInformation.dailyRentalPrice + " TL  --   Rental Status: " + car.rentalStatus + "\r\n";
            }
        }
    }
}
