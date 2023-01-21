namespace InversiApp.API.Models
{
    public class InvestmentDto
    {
        public int ID { get; set; }
        public double ArsUsdRate { get; set; }
        public double BuyPriceArs { get; set; }
        public double BuyPriceUsd { get; set; }
        public string Asset { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
        public double Dividends { get; set; }
        public int Duration { get; set; }
        public double Expenses { get; set; }
        public int investmentType { get; set; } = 1;
        public double Nominals { get; set; }
        public double Rate { get; set; }
        public double UnitValue { get; set; }
    }
}
