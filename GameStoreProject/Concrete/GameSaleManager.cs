using GameStoreProject.Abstract;
using GameStoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject.Concrete
{
    class GameSaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            //Tanımlanan kampanyanın indirimini fiyata uyguluyoruz.
            double newPrice = game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100));

            Console.WriteLine(gamer.FirstName + " oyuncusu " + game.GameName + " adlı oyunu satın aldı.");

            Console.WriteLine("Oyunun fiyatı " + game.GamePrice + "'dır.");
            Console.WriteLine("Uygulanan kampanya " + campaign.CampaignName + " ve indirim tutarı %" + campaign.CampaignDiscount + "'dır.");

            Console.WriteLine("Oyunun indirimli fiyatı " + newPrice +"'dır.");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");



        }
    }
}
