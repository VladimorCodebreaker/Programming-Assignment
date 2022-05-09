using System;

namespace Assignment
{
    public class Address
    {
        private string country { get; set; }
        private string city { get; set; }
        private string street { get; set; }
        private string adress { get; set; }

        public string Country
        {
            get { return this.country; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.country = value;
            }
        }

        public string City
        {
            get { return this.city; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.city = value;
            }
        }

        public string Street
        {
            get { return this.street; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.street = value;
            }
        }

        public string Adress
        {
            get { return this.adress; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.adress = value;
            }
        }
    }
}

