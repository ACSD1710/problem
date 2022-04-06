using MovieLibrary.Classes;
using MovieLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static User GetUserMember(string username, List<User> Users)
        {
            return Users.FirstOrDefault(x => x.UserName.ToLower() == username.ToLower());

        }
        static Employe GetEmployeMember1(string username, List<Employe> Employe)
        {
            return Employe.FirstOrDefault(x => x.UserName.ToLower() == username.ToLower());
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Movie Store - G8");

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter User Name");
                    string username = Console.ReadLine();

                    if (string.IsNullOrEmpty(username))
                    {
                        Console.WriteLine("Enter valid User Name");
                    }




                }

                catch (Exception ex)
                {
                    Console.WriteLine("Exeption occured");
                    Console.WriteLine(ex.Message);
                }
            }
        }


       


        List<User> users = new List<User>
            {
                new User(){FirstName = "User1", LastName = "LastName1", Age = 18, UserName = "user1", Password = "pass1", PhoneNumber = 078123456,  },
                new User(){FirstName = "User2", LastName = "LastName2", Age = 19, UserName = "user2", Password = "pass2", PhoneNumber = 078223456,  },
                new User(){FirstName = "User3", LastName = "LastName3", Age = 20, UserName = "user3", Password = "pass3", PhoneNumber = 078323456,  },
                new User(){FirstName = "User4", LastName = "LastName4", Age = 21, UserName = "user4", Password = "pass4", PhoneNumber = 078423456,  }
            };
        
        List<Employe> Employee = new List<Employe>()
            {
                new Employe {FirstName = "Employee1", LastName = "Employee1", Age = 29, UserName = "employee1", Password = "pass1", PhoneNumber = 078456789, HoursPerMonth = 180 },
                new Employe(){FirstName = "Employee2", LastName = "Employee2", Age = 35, UserName = "employee2", Password = "pass2", PhoneNumber = 078987654, HoursPerMonth = 200 },
                new Employe(){FirstName = "Employee3", LastName = "Employee3", Age = 34, UserName = "employee3", Password = "pass3", PhoneNumber = 078525252, HoursPerMonth = 170 },
            };

        List<Movie> movies = new List<Movie>
            {
                new Movie() {Title = "Title1", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Horror, Year = 1999 },
                new Movie() {Title = "Title2", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Action, Year = 2005 },
                new Movie() {Title = "Title3", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Drama, Year = 2010 },
                new Movie() {Title = "Title4", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Comedy, Year = 2019 },
                new Movie() {Title = "Title5", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.SciFi, Year = 2021 },
                new Movie() {Title = "Title6", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Horror, Year = 2018 },
                new Movie() {Title = "Title7", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Action, Year = 2017 },
                new Movie() {Title = "Title8", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.SciFi, Year = 2014 },
                new Movie() {Title = "Title9", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Drama, Year = 1987 },
                new Movie() {Title = "Title10", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Action, Year = 2004 },
                new Movie() {Title = "Title11", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Comedy, Year = 2013 },
                new Movie() {Title = "Title12", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Horror, Year = 1997 },
                new Movie() {Title = "Title13", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Comedy, Year = 2016 },
                new Movie() {Title = "Title14", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.SciFi, Year = 2019 },
                new Movie() {Title = "Title15", Description = "About Movie: Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Genre = GenreMovie.Comedy, Year = 2004 }
            };



    }





}
       
  

