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
        IVerificationService verificationService;

        

        public GamerManager(IVerificationService verificationService)
        {
            this.verificationService = verificationService;
        }

        public void Add(Gamer gamer)
        {
            if(verificationService.CheckIfRealPerson(gamer)==true)
            {
                Console.WriteLine(gamer.FirstName + " oyuncusu sisteme eklendi.");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız, bilgiler yanlış");
            }
            
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
