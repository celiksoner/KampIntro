using GameStoreProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject.Concrete
{
    class VerificationManager : IVerificationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            int sayi = gamer.NationalityId.Length;

            if(sayi==11)
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
