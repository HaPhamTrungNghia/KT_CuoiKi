using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_4
{
    public class Vehicle
    {
        private string ownerName;
        private string typeOfVehicle;
        private double cylinder;
        private double price;
        private double tax;
        public Vehicle()
        {
        }
        public Vehicle(string ownerName, string typeOfVehicle, double cylinder, double price)
        {
            this.ownerName = ownerName;
            this.typeOfVehicle = typeOfVehicle;
            this.cylinder = cylinder;
            this.price = price;

        }
        public string name()
        {
            return ownerName;

        }
        public string type()
        {
            return typeOfVehicle;

        }
        public double xiLanh()
        {
            return cylinder;
        }
        public double pay()
        {
            return price;

        }
        public void setOwnerName(string ownerName)
        {
            this.ownerName = ownerName;
        }
        public void setTypeOfVehicle(string typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;

        }
        public void setCylinder(double cylinder)
        {
            this.cylinder = cylinder;

        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public double coutTax()
        {
            if (cylinder < 100)
            {
                this.tax = 0.01 * price;
            }
            else if (cylinder >= 100 && cylinder <= 200)
            {
                this.tax = 0.03 * price;

            }
            else
            {
                this.tax = 0.05 * price;
            }
            return this.tax;
        }
        public void show()
        {
            Console.WriteLine(this.toString());

        }
        public string toString()
        {
            return string.Format("{0} \t{1} \t\t{2} \t\t\t{3}", this.ownerName, this.typeOfVehicle, this.cylinder, this.price, this.coutTax());
        }
    }
}

