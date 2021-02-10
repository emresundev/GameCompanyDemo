using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompanyDemo
{
    class GamerValidatitonManager : IGamerValidatitonService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == gamer.FirstName && gamer.LastName == gamer.LastName && gamer.BirthYear == gamer.BirthYear)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
