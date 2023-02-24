using InversiApp.API.Models;
using InversiApp.API.Repository.EF;

namespace InversiApp.API.Repository
{
    public class InvestmentRepository : GenericRepository, IinvestmentRepository
    {
        private InvestmentsContext _context;
        private ILogger<InvestmentRepository> _logger;


        public InvestmentRepository(InvestmentsContext context, ILogger<InvestmentRepository> logger)
        {
            this._context = context;
            _logger = logger;
        }

        public int InsertInvestment(Investment insertInvestment)
        {
            int id = _context.Investments.Add(insertInvestment).Entity.ID;
            _context.SaveChanges();
            return id;
        }

        public async Task<bool> DeleteInvestment(int id)
        {
            var deleted = GetInvestmentById(id);
            if(deleted == null)
            {
                return false;
            }

            var result = await LogExceptionIfFail<bool>(_logger, () =>
            {
                var result = false;
                _context.Investments.Remove(deleted);
                if (_context.SaveChangesAsync().Result > 0)
                    result = true;
                return Task.FromResult(result);
            });

            return result;
        }

        public Investment? GetInvestmentById(int id)
        {
            return _context.Investments.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<Investment> GetInvestments()
        {
            return _context.Investments;
        }

        public Investment? UpdateInvestment(int id, Investment editedInvestment)
        {
            var investment = _context.Investments.FirstOrDefault(w => w.ID == id);
            if (investment == null) 
                return null;

            _context.Entry(investment).CurrentValues.SetValues(editedInvestment);
            _context.SaveChanges();

            return _context.Investments.FirstOrDefault(w => w.ID == id);
        }
    }
}
