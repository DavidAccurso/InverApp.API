using InversiApp.API.Models;
using InversiApp.API.Repository;
using Microsoft.Extensions.Caching.Memory;

namespace InversiApp.API.Domain
{
    public class BcraDomain : IBcraDomain
    {
        private IMemoryCache _memoryCache;
        private IBcraRepository _repo;

        public BcraDomain(IBcraRepository repository, IMemoryCache memoryCache)
        {
            this._memoryCache = memoryCache;
            this._repo = repository;
        }

        public async Task<BcraResponseDto> GetLastPrice()
        {
            BcraResponseDto? response;
            _memoryCache.TryGetValue(DateTime.Today, out response);

            if (response != null)
            {
                return response;
            }

            response = await _repo.GetLastPrice();
            _memoryCache.Set(DateTime.Today, response);
            return response;
        }
    }
}
