using System;
using System.Collections.Generic;
using System.Linq;
using TP3;

namespace BALTIDE_Brandon_TP3_ST2TRD
{
    public class Linq
    {
         /**
         * This method take for parameters a movieCollection instance
         * Use the Linq Syntax and OrderbyDescending on the release date of the movies
         * return the title of the oldest movie
         */
        public  string OldestMovieTitle(MovieCollection movies)
        {
            var oldestMovie = movies.Movies.OrderByDescending(movie=> movie.ReleaseDate).ToList();
            var oldestMovieTitle = oldestMovie[0].Title;
            Console.WriteLine("The oldest movie is : "+oldestMovieTitle);
            return oldestMovieTitle;
        }
        
        /**
         * This method take in parameter a MovieCollection instance
         * Use the function Count
         * return the number of movie in the the collection of the instance
         */
        public  int CountMovie(MovieCollection movies)
        {
            int countedMovies = movies.Movies.Count();
            Console.WriteLine("The total number of movies in this collection is : " +countedMovies);
            return countedMovies;
        }
        
        /**
         * This method take in parameter a MovieCollection instance
         * Use LINQ Syntax and the function count with a condition
         * return the list of the movies where their title contains the letter "e"
         * Print the number of movies in this collection
         */
        public  IEnumerable<MovieCollection.WaltDisneyMovies> CountMovieWithLetterE(MovieCollection movies)
        {
            var listCountedMoviesWithLetterE = movies.Movies.Where(movie => movie.Title.Contains("e")).ToList();
            int countedMoviesWithLetterE = listCountedMoviesWithLetterE.Count();
            Console.WriteLine("The total number of movies in this collection is : " +countedMoviesWithLetterE);
            return listCountedMoviesWithLetterE;
        }
        
        /**
         * This method take in parameter a mMovieCollection instance
         * Use LINQ Syntax and the function CountedMovieWithLetterE and the function count
         * print the number of occurence of the letter f in the title of each movie of the collection
         */
        public  void NumberOfLetterFInTitle(MovieCollection movies)
        {
            var listofElement = CountMovieWithLetterE(movies);
            
            foreach (var movie in listofElement)
            {
                
                
                int count = movie.Title.Where(item => item.Equals('f')).Select(item=>item).Count();
                Console.WriteLine("NB of f in"+ movie.Title +" = "+ count );
            }
        }
        
        /**
         * This method take in parameter a MovieCollection instance
         * Use LINQ Syntax and the function OrderByDescending()
         * print the title of the most expensive movie
         * return the title of the most expensive movie
         */
        public  string TitleOfHighestBudgetFilm(MovieCollection movies)
        {
            var listMostExpensiveMovie = movies.Movies.OrderByDescending(movie=> movie.Budget).ToList();
            var mostExpensiveMovie = listMostExpensiveMovie[0].Title;
            Console.WriteLine("The most expensive movie is : "+ mostExpensiveMovie);
            return mostExpensiveMovie;
        }
        
        /**
         * This method take in parameter a MovieCollection instance
         * Use LINQ Syntax and the function OrderBy() on the BoxOffice
         * print the title of the movie with the lowest box office
         * return the title of the movie with the lowest budget
         */
        
        public  string TitleOfLowestBoxOfficeFilm(MovieCollection movies)
        {
            var listLowestBoxOfficeMovie = movies.Movies.OrderBy(movie=> movie.BoxOffice).ToList();
            var lowestBoxOfficeMovie = listLowestBoxOfficeMovie[0].Title;
            Console.WriteLine("The movie with the lowest box office is : "+ lowestBoxOfficeMovie);
            return lowestBoxOfficeMovie;
        }
        
        /**
         * This method take in parameter a MovieCollection instance
         * Use LINQ Syntax and the function OrderByDescending() on the movie
         * print the first 11 of the list
         * return the list of movie Order in a alphabetical reverse way 
         */
        public  List<MovieCollection.WaltDisneyMovies> OrderByReversedAlphabeticalOrder(MovieCollection movies)
        {
            var listOrderedByReversedAlphabeticalOrder = movies.Movies.OrderByDescending(movie=> movie.Title).ToList();
            for(int i=0; i<=11; i++)
            {
                Console.WriteLine(listOrderedByReversedAlphabeticalOrder[i]);
            }

            
            return listOrderedByReversedAlphabeticalOrder ;
        }
        
        /**
         * This method take in parameter a MovieCollection instance
         * Use LINQ Syntax and the function Count() 
         * return the nb of movie made before 1980
         */
        public  int PrintNbMovieBeforeDate(MovieCollection movies)
        {
            var nbOfMovieBeforeDate = movies.Movies.Count(movie => movie.ReleaseDate.Year < 1980);
            Console.WriteLine("The nb of movie made before 1980 is :" +nbOfMovieBeforeDate);
            return nbOfMovieBeforeDate;
        }
        
        /**
         * This method take in parameter a MovieCollection instance
         * Use LINQ Syntax 
         * return the average running time of the movie that have a vowel as first letter
         */

        public  double? AverageRunningTimeOfMovie(MovieCollection movies)
        {
            char[] vowels = {'A', 'E', 'I', 'O', 'U'};
            double? addition = 0.0;

            var listOfMovie = movies.Movies.Where(movie => vowels.Contains(movie.Title[0])).ToList();
            for (int i = 0; i < listOfMovie.Count; i++)
            {
                addition+= listOfMovie[i].RunningTime;
            }

            var mean = addition / listOfMovie.Count;
            
            Console.WriteLine("The average running time of the movie that have a vowel as first letter is :" +mean);
            return mean;
        }
        
        /**
         * This method take in parameter a MovieCollection instance
         * Use LINQ Syntax 
         * Display the title of the movies that have the letter H and W but without I and T
         */

        public  void MovieWithCertainLetter(MovieCollection movies)
        {
            var listOfMovieWithCertainLetter = movies.Movies.Where(movie =>
                (movie.Title.Contains("H") || movie.Title.Contains("W"))
                && !(movie.Title.Contains("I") || movie.Title.Contains("T")));

            foreach (var movie in listOfMovieWithCertainLetter)
            {
                Console.WriteLine(movie.Title);
            }
        }
        
        
        /**
         * This method take in parameter a MovieCollection instance
         * Use LINQ Syntax 
         * Display  the mean budget/ boxOffices area of the all movie ever 
         */
        public void MeanOfEllement(MovieCollection movies )
        {
            var addition1 = 0.0;
            var addition2 = 0.0;
           
            foreach (var budget in movies.Movies.Select(t => t.Budget).Where(budget => budget != null))
            {
                addition1 = (double) budget;
            }

            var meanBudget = addition1 / movies.Movies.Count;
            int roundMeanBudget = (int)Math.Round(meanBudget);
            Console.WriteLine("The mean budget of all movie ever is " + roundMeanBudget);
           
            foreach (var boxoffice in movies.Movies.Select(t => t.BoxOffice).Where(boxoffice => boxoffice != null))
            {
                addition2 = (double) boxoffice;
            }

            var meanBoxOffice = addition2 / movies.Movies.Count;
            int roundMeanBoxOffice = (int)Math.Round(meanBoxOffice);
            Console.WriteLine("The mean area of all movie ever is " + roundMeanBoxOffice);
        }
        
    }
}