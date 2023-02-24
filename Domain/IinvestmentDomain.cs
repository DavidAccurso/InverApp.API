using InversiApp.API.Models;

namespace InversiApp.API.Domain
{
    public interface IinvestmentDomain
    {
        int InsertInvestment(InvestmentDto insertInvestment);
        IEnumerable<InvestmentDto> GetInvestments();
        InvestmentDto GetInvestmentById(int id);
        Task<bool> DeleteInvestment(int id);
        InvestmentDto UpdateInvestment(int id, InvestmentDto editedInvestment);
    }
}
