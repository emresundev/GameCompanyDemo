using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompanyDemo
{
    class GamerManager : IGamerService
    {
        IGamerValidatitonService _gamerValidatitonService;

        public GamerManager(IGamerValidatitonService gamerValidatitonService)
        {
            _gamerValidatitonService = gamerValidatitonService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerValidatitonService.Validate(gamer))
            {
                Console.WriteLine("New Gamer: " + gamer.FirstName + gamer.LastName + " has been registered");
            }
            else
            {
                Console.WriteLine("Gamer: " + gamer.FirstName + gamer.LastName + "could not validated");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer: " + gamer.FirstName + gamer.LastName + " has been deleted");
        }
    

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer: " + gamer.FirstName + gamer.LastName + " has been updated.");
        }
    }
}
