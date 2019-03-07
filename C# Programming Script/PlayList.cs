using System;

public class Song
{
    private string name;
    public Song NextSong { get; set; }

    public Song(string name)
    {
        this.name = name;
    }

    public bool IsRepeatingPlaylist()
    {
        Song FastChek = this;
        Song SlowCheck = this;
        while (SlowCheck != null && FastChek != null && FastChek.NextSong != null) {
            SlowCheck = SlowCheck.NextSong;
            FastChek = FastChek.NextSong.NextSong;
            if (SlowCheck == null || FastChek == null)
            {

                return false;
            }
            else if (SlowCheck == FastChek)
            {
                return true;
            }
            
        }
        return false;

    }

    public static void Main(string[] args)
    {
        Song first = new Song("Hello");
        Song second = new Song("Eye of the tiger");

        first.NextSong = second;
        second.NextSong = first;

        Console.WriteLine(first.IsRepeatingPlaylist());
        Console.ReadKey();
    }
}