using System;

namespace OOP_LB2
{
    class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private string house;
        private int apartment;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string House
        {
            get { return house; }
            set { house = value; }
        }
        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = 02163;
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.Street = "Honore de Balzac st.";
            address.House = "61-a";
            address.Apartment = 55;
            Console.WriteLine($"Index : {address.Index}\n" +
                $"Country : {address.Country}\n" +
                $"City : {address.City}\n" +
                $"Street : {address.Street}\n" +
                $"House : {address.House}\n" +
                $"Apartment : {address.Apartment}");
        }
    }
}
