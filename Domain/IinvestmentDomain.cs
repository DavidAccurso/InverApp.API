using InversiApp.API.Models;

namespace InversiApp.API.Domain
{
    public interface IinvestmentDomain
    {
        int InsertInvestment(InvestmentDto insertInvestment);
        IEnumerable<InvestmentDto> GetInvestments();
        InvestmentDto GetInvestmentById(int id);
        bool DeleteInvestment(int id);
    }
}
