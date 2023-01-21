using System.ComponentModel.DataAnnotations;

namespace InversiApp.API.Models
{
    public class Investment
    {
        [Key]
        public int ID { get; set; }
        public string Asset { get; set; } = string.Empty;
        public double UnitValue { get; set; }
        public double Nominals { get; set; }
        public DateTime Date { get; set; }

        public InvestmentTypes investmentType { get; set; }
        public double Expenses { get; set; }

        public double ArsUsdRate { get; set; }
        public double BuyPriceUsd { get; set; }
        public double BuyPriceArs { get; set; }

        //Fixed
        public int? Duration { get; set; }
        public double? Rate { get; set; }

        //Equitie
        public double? Dividends { get; set; }

    }
}
