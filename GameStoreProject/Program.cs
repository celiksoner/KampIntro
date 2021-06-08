using GameStoreProject.Abstract;
using GameStoreProject.Concrete;
using GameStoreProject.Entities;
using System;

namespace GameStoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sisteme oyuncu ekliyoruz.
            Gamer gamer1 = new Gamer();
            gamer1.GamerId = 1;
            gamer1.NationalityId = "45466961232";
            gamer1.FirstName = "Soner";
            gamer1.LastName = "Çelik";
            //Oyuncu yönetimi sınıfının referansını oluşturuyoruz.
            GamerManager gamerManager = new GamerManager(new VerificationManager());
            //gamer1'e verdiğimiz değerleri sisteme ekliyoruz.
            gamerManager.Add(gamer1);


            //Sisteme oyun ekliyoruz.
            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "Counter-Strike";
            game1.GamePrice = 50;
            //Oyun yönetimi sınıfının referansını oluşturuyoruz.
            GameManager gameManager = new GameManager();
            //game1'e verdiğimiz değerleri sisteme ekliyoruz.
            gameManager.Add(game1);

            //Sisteme kampanya ekliyoruz.
            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Black Friday";
            campaign1.CampaignDiscount = 10;
            //Kampanya yönetimi sınıfının referansını oluşturuyoruz.
            CampaignManager campaignManager = new CampaignManager();
            //campaign'e verdiğimiz değerleri sisteme ekliyoruz.
            campaignManager.Add(campaign1);

            IGameSaleService gameSaleService = new GameSaleManager();
            gameSaleService.Sale(gamer1, game1, campaign1);

            


            
        }
    }
}
