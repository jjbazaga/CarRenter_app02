using System.Globalization;

namespace CarRental_app.Entites
{
    class Invoice
    {
        public double BasePayment { get; set; }
        public double Tax { get; set; }

        public Invoice()
        {
        }


        public Invoice(double basePayment, double tax)
        {
            BasePayment = basePayment;
            Tax = tax;
        }
        public double TotalPayment
        {
            get { return BasePayment + Tax; }
        }
        public override string ToString()
        {
            return "INVOICE: "
                + "\nBasic Payment: "
                + BasePayment.ToString("f2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("f2", CultureInfo.InvariantCulture)
                + "\nTotal Payment "
                + TotalPayment.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
