using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQlink
{
    public class Game
    {
        private string Title { get; set; }
        private string? Genre { get; set; }
        private int ReleaseYear { get; set; }
        private double Rating { get; set; }
        private int Price { get; set; }

        public Game() {}
        public Game(string title, string genre, int year, double rating, int price)
        {
            Title = title;
            Genre = genre;
            ReleaseYear = year;
            Rating = rating;
            Price = price;
        }

        public void Print()
        {
            var games = new List<Game>()
            { 
                new Game { Title = "The Legend of Zelda", Genre = "Adventure", ReleaseYear = 1986, Rating = 9.5, Price = 60},
                new Game { Title = "Super Mario Bros.", Genre = "Platformer", ReleaseYear = 2022, Rating = 9.2, Price = 50},
                new Game { Title = "Elder Ring", Genre = "RPG", ReleaseYear = 2022, Rating = 9.8, Price = 70},
                new Game { Title = "Stardew Valley", Genre = "Simulation", ReleaseYear = 2016, Rating = 9.0, Price = 15},
                new Game { Title = "Tetris", Genre = "Puzzle", ReleaseYear = 1984, Rating = 8.9, Price = 10}
            };

            // Select
            var allGames = games.Select(game => game.Title).ToList();
            Console.WriteLine("Select: ");
            foreach (var title in allGames)
            {
                Console.WriteLine(title);
            }

            // Where
            var sortGames = games.Where(game => game.Genre == "RPG").ToList();
            Console.WriteLine("Where: ");
            foreach (var game in sortGames)
            {
                Console.WriteLine(game.Title);
            }

            // Any
            var modernGamesExist = games.Any(game => game.ReleaseYear > 2000);
            Console.WriteLine($"Are there any modern games? {modernGamesExist}");

            // OrderBy
            var sorteredByYear = games.OrderBy(game => game.ReleaseYear).ToList();
            Console.WriteLine("Order BY: ");
            foreach (var game in sorteredByYear)
            {
                Console.WriteLine($"{game.Title} {game.ReleaseYear}");
            }

            // OrderBy Descending (по убыванию)
            var sprtedDescinding = games.OrderByDescending(game => game.ReleaseYear).ToList();
            Console.WriteLine("Order BY Descending: ");
            foreach (var game in sprtedDescinding)
            {
                Console.WriteLine($"{game.Title} {game.ReleaseYear}");
            }
        }
    }
}
