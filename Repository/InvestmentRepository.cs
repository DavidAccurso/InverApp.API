using InversiApp.API.Models;
using InversiApp.API.Repository.EF;

namespace InversiApp.API.Repository
{
    public class InvestmentRepository : IinvestmentRepository
    {
        private InvestmentsContext _context;
        public InvestmentRepository(InvestmentsContext context)
        {
            this._context = context;
        }

        public int InsertInvestment(Investment insertInvestment)
        {
            int id = _context.Investments.Add(insertInvestment).Entity.ID;
            _context.SaveChanges();
            return id;
        }

        public bool DeleteInvestment(int id)
        {
            var deleted = GetInvestmentById(id);
            if(deleted == null)
            {
                return false;
            }

            _context.Investments.Remove(deleted);
            _context.SaveChanges();
            return true;
        }

        public Investment GetInvestmentById(int id)
        {
            return _context.Investments.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<Investment> GetInvestments()
        {
            return _context.Investments;
        }
    }
}
