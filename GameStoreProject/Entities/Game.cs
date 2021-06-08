using GameStoreProject.Concrete;

namespace GameStoreProject.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameCategory { get; set; }
        public double GamePrice { get; set; }
    }
}