using System;
class Program
{


    static void Main(string[] args)
    {
        List<playlist> allplaylist = new List<playlist>();
        List<music> allmusic = new List<music>();
       
        List<album> allalbum = new List<album>();
        List<string> friends = new List<string>();
        List<music> playlisthenk = new List<music>();
     
        friends.Add("henk");
        string input1 = "";
        string input2 = "";
        string input3 = "";
        string input4 = "";
        string username = "";
        bool albumfound = false;
        bool musicfound = false;
        


        bool active = true;
        
        allmusic.Add(new music("choaz airflow", "paragon9", "4:13"));
        allmusic.Add(new music("core", "rl grime", "4:10"));
        allmusic.Add(new music("take back the night", "cap", "6:31"));
        allmusic.Add(new music("press start", "mdk", "4:36"));
        foreach (music music in allmusic)
        {
            if (music.name == "choaz airflow" || music.name == "core")
            {
                playlisthenk.Add(music);
               
            }
        
        }
        

        Console.WriteLine("Welcome to the music player!");
        Console.WriteLine("Please enter your username:");
        username = Console.ReadLine();
        new person(username);
        menu();
         void menu() {
            Thread.Sleep(3000);
            Console.Clear();
            if (username == "marco"|| username == "Marco")
            {
                username = "marco polo";
            }
            if (username == "robert" || username == "Robert")
            {
                username = "Rooooooobert ;)";
            }

            Console.WriteLine("Welcome: " + username);
           
            input1 = "";
            Console.WriteLine("1. Add music");
            Console.WriteLine("2. Delete music");
            Console.WriteLine("3. Make playlist");
            Console.WriteLine("4. edit playlist");
            Console.WriteLine("5. friends");
            Console.WriteLine("6. album");
            Console.WriteLine("7. edit album");

            Console.WriteLine("Enter your choice");
            input1 = Console.ReadLine();
            menuoptions(input1);

        }

    void menuoptions(string input1)
        {
            addplaylist("henk's playlist", playlisthenk, "henk");
            switch (input1)
            {
                case "1":
                    Console.WriteLine("Enter the name of the music");
                    input2 = Console.ReadLine();
                    Console.WriteLine("Enter the name of the artist");
                    input4 = Console.ReadLine();
                    Console.WriteLine("Enter the duration of the music");
                    input3 = Console.ReadLine();
                    allmusic.Add(new music(input2, input4, input3));
                    menu();
                    break;
                case "2":
                    Console.WriteLine("Enter the name of the music");
                    input2 = Console.ReadLine();
                    Console.WriteLine("Enter the name of the artist");
                    input4 = Console.ReadLine();
                    Console.WriteLine("Enter the duration of the music");
                    input3 = Console.ReadLine();

                    allmusic.Remove(new music(input2, input4, input3));
                    menu();
                    break;




                case "3":

                    List<music> playlistmusic = new List<music>();
                    Console.WriteLine("Enter the name of the playlist");
                    input2 = Console.ReadLine();
                    active = true;
                    while (active == true)
                    {
                        Console.WriteLine("Enter the name of the music ('type end to stop')");
                        input4 = Console.ReadLine();
                        if (input4 == "end")
                        {
                            active = false;
                            int i = playlistmusic.Count();
                            if (i < 1)
                            {
                                Console.WriteLine("The playlist is  empty");
                            }
                            else
                            {


                                addplaylist(input2, playlistmusic, username);

                                Console.WriteLine("Playlist created");
                                foreach (playlist playlist in allplaylist)
                                {
                                    if (playlist.name == input2)
                                    {
                                        Console.WriteLine("The playlist contains:");
                                        foreach (music music in playlist.songs)
                                        {
                                            Console.WriteLine(music.name);
                                        }
                                    }
                                    {

                                    }

                                }


                            }
                        }
                        else
                        {
                            foreach (music music in allmusic)
                            {


                                if (music.Name == input4)
                                {
                                    musicfound = true;
                                    playlistmusic.Add(music);


                                    Console.WriteLine(music);


                                }

                            }
                            if (musicfound)
                            {
                                Console.WriteLine("The music is added");
                            }
                            else
                            {
                                Console.WriteLine("The music is not found");
                            }

                        }
                    }
                    menu();

                    break;
                case "4":
                    Console.WriteLine("what do you want to edit in your playlist");
                    input2 = Console.ReadLine();
                    if (input2 == "add")
                    {
                        Console.WriteLine("in which playlist");
                        input2 = Console.ReadLine();
                        Console.WriteLine("Enter the name of the music");
                        input4 = Console.ReadLine();
                        try
                        {
                            foreach (music music in allmusic)
                            {



                                if (music.Name == input4)
                                {
                                    musicfound = true;
                                    foreach (playlist playlist in allplaylist)
                                    {
                                        if (playlist.name == input2)
                                        {
                                            playlist.songs.Add(music);
                                            Console.WriteLine("The music is added");
                                        }
                                    }
                                }






                            }
                        }
                        catch
                        {
                            Console.WriteLine("music or playlist not found");
                        }

                    }




                    if (input2 == "delete")
                    {
                        Console.WriteLine("in which playlist");
                        input2 = Console.ReadLine();
                        foreach (playlist playlist in allplaylist)
                        {
                            if (playlist.Name == input2)
                            {
                                Console.WriteLine("Enter the name of the music");
                                input4 = Console.ReadLine();
                                foreach (music music in playlist.songs)
                                {
                                    if (music.Name == input4)
                                    {
                                        playlist.songs.Remove(music);
                                        Console.WriteLine("The music is deleted");
                                        menu();
                                    }
                                }
                            }
                        }
                    }
                    if (input2 == "delete playlist")
                    {
                        Console.WriteLine("which playlist?");
                        input2 = Console.ReadLine();
                        foreach (playlist playlist in allplaylist)
                        {
                            if (playlist.Name == input2)
                            {
                                playlist test2 = playlist;
                                test2.deleteplaylist();
                                Console.WriteLine("The playlist is deleted");
                            }

                        }

                    }

                    menu();
                    break;

                case "5":

                    if (friends == null || friends.Count == 0)
                    {
                        Console.WriteLine("The friendlist is empty");
                        Console.WriteLine("Enter the name of the friend");
                        input2 = Console.ReadLine();
                        friends.Add(input2);
                    }

                    Console.WriteLine("These are all your friends:");
                    foreach (string friend in friends)
                    {
                        Console.WriteLine(friend);
                    }
                    Console.WriteLine("wanna add a friend?");
                    input2 = Console.ReadLine();
                    if (input2 == "yes")
                    {
                        Console.WriteLine("Enter the name of the friend you want to add");
                        input2 = Console.ReadLine();
                        friends.Add(input2);
                        Console.WriteLine("The friend is added");
                    }
                    else if (input2 == "delete")
                    {
                        Console.WriteLine("which friend");
                        input2 = Console.ReadLine();
                        friends.Remove(input2);
                        Console.WriteLine("The friend is deleted");
                    }
                    else if (input2 == "copy playlist")
                    {
                        Console.WriteLine("which friend");
                        input3 = Console.ReadLine();
                        string data1 = "";
                        List<music> tempmusic = new List<music>();
                        try
                        {
                            foreach (string friend in friends)
                            {
                                if (input3 == friend)
                                {
                                    Console.WriteLine("which playlist");
                                    input2 = Console.ReadLine();
                                    foreach (playlist playlist in allplaylist)
                                    {
                                        if (playlist.person == input3)
                                        {
                                            if (playlist.name == input2)
                                            {
                                                data1 = playlist.name;
                                                tempmusic = playlist.songs;

                                            }

                                        }
                                    }
                                }
                            }
                            foreach (music music in tempmusic)
                            {
                                Console.WriteLine(music);
                            }

                            addplaylist(data1, tempmusic, username);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("The friend is not found");
                        }


                    }


                    menu();




                    break;
                case "6":
                    List<music> album = new List<music>();
                    Console.WriteLine("make album");
                    Console.WriteLine("Enter the name of the album");
                    input2 = Console.ReadLine();
                    Console.WriteLine("Enter the name of the artist");
                    input4 = Console.ReadLine();

                    Console.WriteLine("Enter the name of the music");
                    input3 = Console.ReadLine();
                    foreach (music music in allmusic)
                    {



                        if (music.Name == input4)
                        {
                            if (music.Artist == input4)
                            {
                                musicfound = true;
                                album.Add(music);
                                Console.WriteLine("The music is added");
                                addalbums(input2, album, input4);
                            }
                            else
                            {
                                Console.WriteLine("The music created by you");
                            }



                            Console.WriteLine(music);


                        }

                    }




                    break;
                case "7":
                    Console.WriteLine("what do you want to edit in your album");
                    input2 = Console.ReadLine();
                    if (input2 == "add")
                    {
                        Console.WriteLine("from which album?");
                        input2 = Console.ReadLine();
                        foreach (album allbum in allalbum)
                        {
                            if (allbum.Name == input2)
                            {
                                Console.WriteLine("Enter the name of the music");
                                input4 = Console.ReadLine();
                                foreach (music music in allmusic)
                                {



                                    if (music.Name == input4)
                                    {
                                        album test2 = allbum;
                                        test2.addSong(music);
                                        Console.WriteLine("The music is added");
                                    }

                                }
                            }
                        }




                    }
                    if (input2 == "delete")
                    {
                        Console.WriteLine("from which album?");
                        input2 = Console.ReadLine();
                        foreach (album allbum in allalbum)
                        {
                            if (allbum.Name == input2)
                            {
                                album test2 = allbum;
                                test2.deletesong();
                            }
                        }
                    }


                    if (input2 == "delete album")

                    {
                        Console.WriteLine("which album?");
                        input2 = Console.ReadLine();
                        foreach (album allbum in allalbum)
                        {
                            if (allbum.Name == input2)
                            {
                                allalbum.Remove(allbum);
                            }

                        }
                    }


                    break;
                case "8":
                    Console.WriteLine("what music do you wanna play?");
                    input2 = Console.ReadLine();
                    foreach (music music in allmusic)
                    {
                        if (music.Name == input2)
                        {
                            Console.WriteLine(music);
                            Console.WriteLine("do you wanna play it?");
                            input2 = Console.ReadLine();
                            if (input2 == "yes")
                            {
                                Console.WriteLine("playing");
                                Console.WriteLine(music.name);
                                string plit = music.length.Split(':')[0];
                                string plit2 = music.length.Split(':')[1];
                                int totalsplit1 = Convert.ToInt32(plit) * 60;
                                int totalsplit2 = Convert.ToInt32(plit2) + totalsplit1 * 1000;
                                Thread.Sleep(totalsplit2);
                            }
                            else if (input2 == "no")
                            {
                                Console.WriteLine("stopped");
                            }
                        }
                    }
            
                    break;
                case "9":
                    Console.WriteLine("which playlist did you wanna play?");
                    input2 = Console.ReadLine();

                    foreach (playlist playlist in allplaylist)
                    {
                        if (playlist.name == input2)
                        {
                            Console.WriteLine(playlist);

                            Console.WriteLine("do you wanna play it?");
                            input2 = Console.ReadLine();
                            if (input2 == "yes")
                            {
                                Console.WriteLine("do you wanna shuffle?");
                                input2 = Console.ReadLine();
                                if (input2 == "yes")
                                {
                                    Console.WriteLine("shuffling");
                                    Random rnd = new Random();
                                    int rndnumber = rnd.Next(0, playlist.songs.Count);
                                    Console.WriteLine(playlist.songs[rndnumber]);
                                    string plit = playlist.songs[rndnumber].length.Split(':')[0];
                                    string plit2 = playlist.songs[rndnumber].length.Split(':')[1];
                                    int totalsplit1 = Convert.ToInt32(plit) * 60;
                                    int totalsplit2 = Convert.ToInt32(plit2) + totalsplit1 * 1000;
                                    Thread.Sleep(totalsplit2);
                                }
                                else if (input2 == "no")
                                {
                                    Console.WriteLine("playing");
                                    foreach (music music in playlist.songs)
                                    {
                                        Console.WriteLine(music);
                                        string plit = music.length.Split(':')[0];
                                        string plit2 = music.length.Split(':')[1];
                                        int totalsplit1 = Convert.ToInt32(plit) * 60;
                                        int totalsplit2 = Convert.ToInt32(plit2) + totalsplit1 * 1000;
                                        Thread.Sleep(totalsplit2);
                                    }
                                }
                            }
                        }
                    }
                    
                    break;
                    default:
                    Console.WriteLine("Invalid input");
                    menu();
                    break;
            }
            void addplaylist(string name, List<music> playlist, string gebruiker)
            {

                allplaylist.Add(new playlist(name, playlist, gebruiker));

            }
            void addalbums(string name, List<music> album, string nameartist)
            {
                allalbum.Add(new album(name, album, nameartist));
            }
           
        }
            
        
            
        
    }










}