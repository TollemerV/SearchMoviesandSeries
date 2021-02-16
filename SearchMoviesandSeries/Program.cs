using SearchMovie.Model;
using System;
using System.Collections.Generic;
using static SearchMovie.Manager;


namespace SearchMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            var Quit = false;

            //  We display application's menu

            while (!Quit)
            {
                Console.WriteLine("1 - Find media by name");
                Console.WriteLine("2 - Details of a media");
                Console.WriteLine("3 - Display all media");
                Console.WriteLine("4 - Quit");
                Console.WriteLine(string.Empty);
                Console.WriteLine("Select an option : ");

                var optionSelected = Console.ReadLine();
                var Choice = int.Parse(optionSelected);
                Manager manager = new Manager();

                if (Choice == 1)
                {
                    Console.WriteLine("Search a Movie : ");
                    var search = Console.ReadLine();
                    List<Movies> movies = manager.SearchMovie(search);

                    foreach (Movies movie in movies)
                    {
                        Console.WriteLine(movie.Title);
                    }


                }
                else if (Choice == 2)
                {


                }
                else if (Choice == 3)
                {

                }
                else if (Choice == 4)
                {

                }
                else if (Choice == 5)
                {
                    Quit = true;
                }
                else
                {
                    Console.WriteLine("Invalid option, please retry");
                    Console.WriteLine(string.Empty);
                }
            }
        }
    }
}

