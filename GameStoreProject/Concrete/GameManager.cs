using GameStoreProject.Abstract;
using GameStoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " oyunu sisteme eklendi.");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " oyunu sistemden silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " oyunu güncellendi.");
            Console.WriteLine("Güncel oyun ismi " + game.GameName);
        }
    }
}
