using MusicTaste.Models;

namespace MusicTaste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selectedPersonId;

            Song stairwayToHeaven = new Song("Stairway to Heaven", 483, GenreEnum.Rock);
            Song straighOuttaCompton = new Song("Straigh Outta Compton", 260, GenreEnum.Hip_Hop);
            Song noUfos = new Song("No UFO's", 408, GenreEnum.Techno);
            Song ninthSymphony = new Song("Symphony 9, Op. 125", 698, GenreEnum.Classical);

            List<Song> songsEmptyList = new List<Song>() { };
            List<Song> songsRock = new List<Song>() { stairwayToHeaven, ninthSymphony};
            List<Song> songsHipHop = new List<Song>() { straighOuttaCompton, noUfos};
            List<Song> songsTechno = new List<Song>() { noUfos, ninthSymphony};
            List<Song> songsClassical = new List<Song>() { ninthSymphony, stairwayToHeaven};

            Person bob = new Person(1, "Bob", "Bobsky", 35, GenreEnum.Rock, songsRock);
            Person jane = new Person(2, "Jane", "Janeson", 22, GenreEnum.Hip_Hop, songsHipHop);
            Person george = new Person(3, "George", "Brown", 40, GenreEnum.Techno, songsTechno);
            Person martin = new Person(4, "Martin", "Jacobs", 70, GenreEnum.Classical, songsClassical);
            Person jasmine = new Person(5, "Jasmine", "Knowno", 70, GenreEnum.Classical, songsEmptyList);
            Person michael = new Person(6, "Michael", "Phew", 70, GenreEnum.Classical, songsEmptyList);

            List<Person> persons = new List<Person>() { bob, jane, george, martin, jasmine, michael};

            while (true)
            {
                Console.WriteLine("Please type the id of a person from the list below:\n");
                foreach (Person person in persons)
                {
                    Console.WriteLine($"Id: {person.Id}, name: {person.FirstName} {person.FirstName}");
                }
                string userSelection = Console.ReadLine();
                

                if (!int.TryParse(userSelection, out selectedPersonId))
                {
                    Console.WriteLine("Invalid input!\n");
                    continue;
                }

                if (int.TryParse(userSelection, out selectedPersonId))
                {
                    if (selectedPersonId < 1 || selectedPersonId > persons.Count())
                    {
                        Console.WriteLine($"There is no ID {selectedPersonId}.");
                        continue;
                    } else
                    {
                        GetFavSongs(persons[selectedPersonId - 1]);
                    }
                }

                Console.WriteLine("\nWould you like to check music taste of other person (y/n)?");
                string checkAgain = Console.ReadLine();

                if (checkAgain.ToLower() == "y")
                {
                    continue;
                }
                break;
            }


        }

        public static void GetFavSongs(Person person)
        {
            if (person.FavoriteSongs.Count == 0)
            {
                Console.WriteLine($"\n{person.FirstName} {person.LastName} hates music!");
            } else
            {
                List<Song> favoriteSongs = person.FavoriteSongs;
                
                Console.WriteLine($"\n{person.FirstName} {person.LastName} loves {person.FavoriteMusicType} and favorite songs are:\n");
                foreach (Song titleOfTheSong in favoriteSongs)
                {
                    Console.WriteLine($"- {titleOfTheSong.Title}");
                }
            }
        }
    }
}
