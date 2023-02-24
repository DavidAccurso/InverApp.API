using InversiApp.API.Models;

namespace InversiApp.API.Repository
{
    public interface IinvestmentRepository
    {
        int InsertInvestment(Investment insertInvestment);
        IEnumerable<Investment> GetInvestments();
        Investment? GetInvestmentById(int id);
        Task<bool> DeleteInvestment(int id);
        Investment? UpdateInvestment(int id, Investment editedInvestment);
    }
}
