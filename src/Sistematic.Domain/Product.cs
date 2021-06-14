namespace Sistematic.Domain
{
    public class Product
    {
        public string Code { get; set; }
        public string Cfop { get; set; }
        public decimal Percent { get; set; }
        public decimal VlContabil { get; set; }
        public decimal BaseCalc { get; set; }
        public decimal Icms { get; set; }
    }
}