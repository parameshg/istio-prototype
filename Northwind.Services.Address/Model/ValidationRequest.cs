namespace Northwind.Services.Address.Model
{
    public class ValidationRequest
    {
        public string Address { get; set; }

        public string Country { get; set; }

        public int Zip { get; set; }
    }
}