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
        public double? Dividends { get; set; } = 0;
        public int? Duration { get; set; } = 0;
        public double? Expenses { get; set; } = 0;
        public InvestmentTypes investmentType { get; set; } = InvestmentTypes.Fixed;
        public double Nominals { get; set; } = 0;
        public double? Rate { get; set; } = 0;
        public double UnitValue { get; set; } = 0;
    }
}
