﻿using SearchMovie.Model;
using System;
using System.Collections.Generic;
using static SearchMovie.Manager;

/////////////////////////////////////////////////////////////////////////////////
/////////////// https://github.com/TollemerV/SearchMoviesandSeries.git  ////////
/////////////////////////////////////////////////////////////////////////////

namespace SearchMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            var quit = false;


            ///////////////////////////////////////////
            /////////////// PARAMETRES CONSOLE ////////
            ///////////////////////////////////////////
            

            //var commandLineApplication = new CommandLineApplication(throwOnUnexpectedArg: false);
            //_moviesCmd = commandLineApplication.Option("-m|--movies <title>", "Search movies.", CommandOptionType.SingleValue);

            //commandLineApplication.HelpOption("-?|-h|--help");
            //commandLineApplication.OnExecute(() =>
            //{
            //    if (_moviesCmd.Value() != null)
            //    {
            //        searchMovies(_moviesCmd.Value());
            //    }
            //    return 0;
            //});
            //commandLineApplication.Execute(args);

            while (!quit)
            {
                ///////////////////////////////////////////
                /////////////// MENU  /////////////////////
                ///////////////////////////////////////////
                
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
                        ///////////////// FIND A MOVIE ///////////////////////
                       
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
                    ////////////////////EXCEPTION/////////////////////
                    
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
                        ///////////////// MOVIES DETAILS ///////////////////////
                        
                        Console.WriteLine("Search a Movie you want details : ");
                        var searchid = Console.ReadLine();

                        DetailsMovies detailsMovies = manager.DetailsMovie(searchid);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(detailsMovies.ToString());

                        Console.ResetColor();

                    }
                    ////////////////////EXCEPTION/////////////////////
                    
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

                        ///////////////// FIND A SERIE ///////////////////////
                        
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

                    ////////////////////EXCEPTION/////////////////////
                   
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
                        ///////////////// DETAILS SERIES ///////////////////////
                        
                        Console.WriteLine("Search a Movie you want details : ");
                        var searchid = Console.ReadLine();

                        DetailsSeries detailsSeries = manager.DetailsSeries(searchid);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(detailsSeries.ToString());

                        Console.ResetColor();

                    }
                    ////////////////////EXCEPTION/////////////////////
                    
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
                    ///////////////// QUIT THE PROGRAM ///////////////////////
                    
                    quit = true;
                }
                else
                {
                    ////////////////////EXCEPTION/////////////////////
                  
                    Console.WriteLine("Invalid option, please retry");
                    Console.WriteLine(string.Empty);
                }
            }
        }
    }
}

