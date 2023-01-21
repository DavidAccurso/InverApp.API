using AutoMapper;
using InversiApp.API.Models;
using InversiApp.API.Repository;

namespace InversiApp.API.Domain
{
    public class InvestmentsDomain : IinvestmentDomain
    {
        private IinvestmentRepository _repository;
        private IMapper mapper;

        public InvestmentsDomain(IinvestmentRepository repository, IMapper automapper)
        {
            _repository = repository;
            mapper = automapper;
        }

        public int InsertInvestment(InvestmentDto insertInvestment)
        {
            var insert = mapper.Map<InvestmentDto, Investment>(insertInvestment);
            return _repository.InsertInvestment(insert);
        }

        public InvestmentDto GetInvestmentById(int id)
        {
            var result = _repository.GetInvestmentById(id);
            return mapper.Map<Investment, InvestmentDto>(result);
        }

        public IEnumerable<InvestmentDto> GetInvestments()
        {
            var result = _repository.GetInvestments();
            return mapper.Map<IEnumerable<Investment>, IEnumerable<InvestmentDto>>(result);
        }

        public bool DeleteInvestment(int id)
        {
            return _repository.DeleteInvestment(id);
        }
    }
}
