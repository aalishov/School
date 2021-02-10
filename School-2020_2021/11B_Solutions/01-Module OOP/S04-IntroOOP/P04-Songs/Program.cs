namespace P04_Songs
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter song number:");
            int n = int.Parse(Console.ReadLine());

            Song[] songs = new Song[n];

            for (int i = 0; i < n; i++)
            {
                string[] songInfo = Console.ReadLine()
                    .Split('_')
                    .ToArray();

                string list = songInfo[0];
                string name = songInfo[1];
                string time = songInfo[2];

                songs[i] = new Song();

                songs[i].TypeList = list;
                songs[i].Name = name;
                songs[i].Time = time;
            }
            Console.Write("Playlist: ");
            string printLisType = Console.ReadLine();

            Song[] selectedSong = songs
                .Where(x => x.TypeList == printLisType)
                .ToArray();

            for (int i = 0; i < selectedSong.Length; i++)
            {
                Console.WriteLine(selectedSong[i].Name);
            }
        }
    }
}
