using GameStoreProject.Abstract;
using GameStoreProject.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject
{
    public class Gamer
    {
        public int GamerId { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthOfDate { get; set; }
        

    }
}
