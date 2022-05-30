namespace CarRental_app.Entites
{
    class Vehicle
    {
        public string Model { get; set; }

        public Vehicle()
        {
        }
        public Vehicle(string model)
        {
            Model = model;
        }
    }
}