using DomainLayer.Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class WinnerRepository : IWinnerRepository
    {
        private DBContext _dBContext;

        public Winner Add(Winner winner)
        {
            using (_dBContext = new DBContext())
            {
                winner.CreateOn = DateTime.Now;
                _dBContext.Winners.AddRange(winner);
                _dBContext.SaveChanges();

                return winner;
            }
        }

    }
}
