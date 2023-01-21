using InversiApp.API.Models;

namespace InversiApp.API.Domain
{
    public interface IBcraDomain
    {
        Task<BcraResponseDto> GetLastPrice();
    }
}
