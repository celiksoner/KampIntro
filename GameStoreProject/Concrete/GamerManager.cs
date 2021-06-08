using GameStoreProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject.Concrete
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " oyuncusu sisteme eklendi.");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " oyuncusu sistemden silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " oyuncusunun adı güncellendi.");
            Console.WriteLine("Oyuncunun güncel adı " + gamer.FirstName);
        }
    }
}
