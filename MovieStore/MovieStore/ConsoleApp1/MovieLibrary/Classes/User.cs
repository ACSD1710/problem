using MovieLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary.Classes
{
    public class User : Member
    {
        public int UserNumber { get; set; }
        public EnumSubscription TypeOfSubscription { get; set; }
        public List<Movie> Movie { get; set; }
        public User()
        {
           
            Role = RoleEnum.Member;
            UserNumber = new Random().Next(1, 10000);
            Movie = new List<Movie>();

           
        }
    }
   
}
