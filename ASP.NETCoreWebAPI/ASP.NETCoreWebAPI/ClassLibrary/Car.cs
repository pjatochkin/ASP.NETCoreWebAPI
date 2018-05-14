using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car
    {
        private int id;
        private decimal bill;
        private Settings.carsType type;

        Random rnd = new Random();

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public decimal _bill
        {
            get { return bill; }
            set { bill = value; }
        }

        public Settings.carsType _type
        {
            get { return type; }
            set { type = value; }
        }

        public Car()
        { }
        public Car(int idCar, Settings.carsType typeCar, decimal billCar)
        {
            _id = idCar;
            _type = typeCar;
            _bill = billCar;
        }

        public decimal AddMoney(decimal _money)
        {
            bill += _money;
            return bill;
        }

        public decimal TakeMoney(decimal _money)
        {
            bill -= _money;
            return bill;
        }
    }
}
