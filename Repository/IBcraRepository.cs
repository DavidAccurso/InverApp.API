using InversiApp.API.Models;

namespace InversiApp.API.Repository
{
    public interface IBcraRepository
    {
        Task<BcraResponseDto> GetLastPrice();
    }
}
