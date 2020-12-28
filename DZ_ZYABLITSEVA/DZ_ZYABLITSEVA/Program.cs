using System;

namespace DZ_ZYABLITSEVA
{
    public class Song
    {
        public int Year;

        public string Title, Gener;
        public Compositor Author, Author1;
        public Album Album;
        public Song()
        {
            Title = "Unknown";
            Gener = "Folk song";
            Year = 1971;
            Console.WriteLine(" Title: {0}\n Gener: {1}\n Year: {2}\n", Title, Gener, "Unknown");
        }
        public Song(string name, string gener, int year) //without Compositor and w/o album
        {
            Title = name;
            Gener = gener;
            Year = year;
            Console.WriteLine("Title: {0}\n Gener: {1}\n Year: {2}\n", Title, Gener, Year);
        }
        public Song(string name, string gener, int year, Compositor author) //with One Compositor and w/o album
        {
            Title = name;
            Gener = gener;
            Year = year;
            Author = author;
            Console.WriteLine(" Title: {0}\n Gener: {1}\n Year: {2}\n Written by: {3}\n", Title, Gener, Year, Author.Getname());

        }
        public Song(string name, string gener, int year, Compositor author1, Compositor author2)//With Two Compositor and w/o album
        {
            Title = name;
            Gener = gener;
            Year = year;
            Author1 = author1;
            Author = author2;
            Console.WriteLine(" Title: {0}\n Gener: {1}\n Year: {2}\n Written by: {3}, {4}\n", Title, Gener, Year, Author1.Getname(), Author.Getname());

        }
        public Song(string name, string gener, int year, Album album) //without Compositor and with album
        {
            Title = name;
            Gener = gener;
            Year = year;
            Album = album;
            Console.WriteLine("Title: {0}\n Album: {3}\n Gener: {1}\n Year: {2}\n", Title, Gener, Year, Album.GetAlbum()); ;
        }
        public Song(string name, string gener, int year, Compositor author, Album album) //with One Compositor and with album
        {
            Title = name;
            Gener = gener;
            Year = year;
            Author = author;
            Album = album;
            Console.WriteLine(" Title: {0}\n Album: {4}\n Gener: {1}\n Year: {2}\n Written by: {3}\n", Title, Gener, Year, Author.Getname(), Album.GetAlbum());

        }
        public Song(string name, string gener, int year, Compositor author1, Compositor author2, Album album)//With Two Compositor and with album
        {
            Title = name;
            Gener = gener;
            Year = year;
            Author1 = author1;
            Author = author2;
            Album = album;
            Console.WriteLine(" Title: {0}\n Album: {5}\n Gener: {1}\n Year: {2}\n Written by: {3}, {4}\n", Title, Gener, Year, Author1.Getname(), Author.Getname(), Album.GetAlbum());

        }

    }

    public class Compositor
    {
        public string Name, Surname;

        public Compositor() 
        {
            Surname = "Unknown";
            Name = "Unknown";
            Console.WriteLine("Name: {0}\nSurname: {1}\n", Name, Surname);
        }
        public Compositor(string name, string surname) 
        {
            Name = name;
            Surname = surname;
            Console.WriteLine("Имя: {0}\nФамилия: {1}\n", Name, Surname);
        }
        public string Getname()
        {
            string author = Name + ' ' + Surname;
            return author;
        }
    }

    public class Album
    {
        public string Title;
        public int Year;

        public Album()
        {
            Title = "Unknown";
            Year = 1971;
            Console.WriteLine("Title: {0}\nYear: {1}\n", Title, Year);
        }
        public Album(string name, int year)
        {
            Title = name;
            Year = year;
            Console.WriteLine("Title: {0}\nYear: {1}\n", Title, year);
        }
        public string GetAlbum()
        {
            string album = Title;
            return album;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Compositor TPR = new Compositor("The Pretty Reckless", "");
            Compositor S = new Compositor("SoundGarden", "");
            Compositor MM = new Compositor("Marilyn", "Manson");
            Album DXBR = new Album("Death by Rock and Roll", 2021);
            Song T25 = new Song("25", "Rock", 2020, TPR, DXBR);
            Song DS = new Song("Dope Show", "Rock", 2010, TPR, MM);
            Song HZ = new Song();

            Console.ReadKey();
        }
    }
}