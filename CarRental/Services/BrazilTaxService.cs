namespace CarRental_app.Services
{
    class BrazilTaxService : ITaxService   //realização de interface
    {
        public double Tax(double amount)
        {
            if(amount <= 100.0)
            {
                return amount * 0.20;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}