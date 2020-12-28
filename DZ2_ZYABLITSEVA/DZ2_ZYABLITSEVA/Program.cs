using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DZ2_ZYABLITSEVA
{
    public class Song
    {
        public string Title { get; set; }
        public string Gener { get; set; }
        public int Year { get; set; }
        public Album Albu { get; set; }
        public Compositor[] Authors { get; set; }
    }
    public class Compositor
    {
        public string Name { get; set; }
        public string Surname { get; set; }

    }
    public class Album
    {
        public string Title { get; set; }
        public int Year { get; set; }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            Compositor EJ = new Compositor
            {
                Name = "Elthon",
                Surname = "John"

            };
            Compositor OO = new Compositor
            {
                Name = "Ozzie",
                Surname = "Osbourne"

            };
            Album OM = new Album
            {
                Title = "Ordinary man",
                Year = 2020,
            };
            Song OM1 = new Song
            {
                Title = "Ordinary man",
                Year = 2020,
                Gener = "rock/alternative",
                Authors = new Compositor[] { EJ, OO },
                Albu = OM

            };


            string json = JsonSerializer.Serialize<Song>(OM1);
            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}