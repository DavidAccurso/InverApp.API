using InversiApp.API.Models;

namespace InversiApp.API.Repository
{
    public interface IinvestmentRepository
    {
        int InsertInvestment(Investment insertInvestment);
        IEnumerable<Investment> GetInvestments();
        Investment GetInvestmentById(int id);
        bool DeleteInvestment(int id);
    }
}
