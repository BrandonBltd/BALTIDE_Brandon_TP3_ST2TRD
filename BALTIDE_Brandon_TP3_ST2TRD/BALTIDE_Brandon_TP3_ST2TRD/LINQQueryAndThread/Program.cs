using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using TP3;

namespace BALTIDE_Brandon_TP3_ST2TRD
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            MovieCollection movieCollection = new MovieCollection();
            Linq l = new Linq();
            Multithreading multithreading = new Multithreading();
            
            

           // l.OldestMovieTitle(movieCollection);
            //l.CountMovie(movieCollection);
           // l.CountMovieWithLetterE(movieCollection);
          //  l.NumberOfLetterFInTitle(movieCollection);
            //l.TitleOfHighestBudgetFilm(movieCollection);
           // l.TitleOfLowestBoxOfficeFilm(movieCollection);
            //l.OrderByReversedAlphabeticalOrder(movieCollection);
            //l.PrintNbMovieBeforeDate(movieCollection);
            //l.AverageRunningTimeOfMovie(movieCollection);
            //l.MovieWithCertainLetter(movieCollection);
           // l.MeanOfEllement(movieCollection);
           
           multithreading.Action();
           
            /* We can also use a timer
             
            string messageObj = "*";
            Timer timer = new Timer(Print, " ",10000,50);
                            
            Timer timer2 = new Timer(Print, "*", 11000,40);
            Timer timer3 = new Timer(Print,"°",9000,20);
            Console.ReadLine();
            timer.Dispose();
            timer2.Dispose();
            timer3.Dispose();
            */
        }

        private static void Print(object msg)
        {
            string message = (string) msg;
            Console.Write(message);
        }
        
       
        












    }
}