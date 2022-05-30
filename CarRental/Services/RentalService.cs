using System;
using CarRental_app.Entites;

namespace CarRental_app.Services
{
    class RentalService
    {
        public double PricePerHour  { get; private set; }
        public double PricePerDay { get; private set; }

        //private BrazilTaxService _brazilTaxService = new BrazilTaxService(); //dependencia muito forte
        private ITaxService _taxService; //declarando a variável sem criar o objeto por aqui. 

        public RentalService()
        {
        }

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;  //criando uma injeção de dependência
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if(duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }   
}