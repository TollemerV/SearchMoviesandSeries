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
            var quit = false;

            while (!quit)
            {
                Console.WriteLine("1 - Find a movie by name");
                Console.WriteLine("2 - Details of a movie");
                Console.WriteLine("3 - Find a serie by name");
                Console.WriteLine("4 - Details of a serie");
                Console.WriteLine("5 - Quit");
                Console.WriteLine(string.Empty);
                Console.WriteLine("Select an option : ");

                var optionSelected = Console.ReadLine();
                var Choice = int.Parse(optionSelected);
                Manager manager = new Manager();

                if (Choice == 1)
                {
                    try
                    { 
                        Console.WriteLine("Search a Movie : ");
                        var search = Console.ReadLine();
                        List<Movies> movies = manager.SearchMovie(search);

                            Console.ForegroundColor = ConsoleColor.Blue;

                            for (int i = 1; i <= 15; i++)
                            {
                                Console.WriteLine(movies[i].ToString());
                            }
                            Console.ResetColor();
                        
                    }
                    catch (FailureConnectionException e)
                    {
                        Console.WriteLine(e.message);
                    }
                    catch (EmptyDataException e)
                    {
                        Console.WriteLine(e.message);
                    }



                }
                else if (Choice == 2)
                {
                    try
                    {
                        Console.WriteLine("Search a Movie you want details : ");
                        var searchid = Console.ReadLine();

                        DetailsMovies detailsMovies = manager.DetailsMovie(searchid);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(detailsMovies.ToString());

                        Console.ResetColor();

                    }
                    catch (FailureConnectionException e)
                    {
                        Console.WriteLine(e.message);
                    }
                    catch (EmptyDataException e)
                    {
                        Console.WriteLine(e.message);
                    }

                }
                else if (Choice == 3)
                {
                    try
                    {
                        Console.WriteLine("Search a Serie : ");
                        var search = Console.ReadLine();
                        List<Series> series = manager.SearchSeries(search);

                        Console.ForegroundColor = ConsoleColor.Green;

                        for (int i = 1; i <= 15; i++)
                        {
                            Console.WriteLine(series[i].ToString());
                        }
                        Console.ResetColor();

                    }
                    catch (FailureConnectionException e)
                    {
                        Console.WriteLine(e.message);
                    }
                    catch (EmptyDataException e)
                    {
                        Console.WriteLine(e.message);
                    }

                }
                else if (Choice == 4)
                {
                    try
                    {
                        Console.WriteLine("Search a Movie you want details : ");
                        var searchid = Console.ReadLine();

                        DetailsSeries detailsSeries = manager.DetailsSeries(searchid);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(detailsSeries.ToString());

                        Console.ResetColor();

                    }
                    catch (FailureConnectionException e)
                    {
                        Console.WriteLine(e.message);
                    }
                    catch (EmptyDataException e)
                    {
                        Console.WriteLine(e.message);
                    }
                }
                else if (Choice == 5)
                {
                    quit = true;
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

