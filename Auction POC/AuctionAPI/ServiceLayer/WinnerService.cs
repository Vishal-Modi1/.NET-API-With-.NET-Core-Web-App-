using DomainLayer.Entities;
using Repositories;
using Repositories.Interface;
using Services.Interface;

namespace Services
{
    public class WinnerService : IWinnerService
    {
        private readonly IWinnerRepository _winnerRepository;
        public WinnerService()
        {
            _winnerRepository = new WinnerRepository();
        }

        public Winner Add(Winner winner)
        {
            return _winnerRepository.Add(winner);
        }
    }
}
