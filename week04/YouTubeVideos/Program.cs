using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
class Program
{
    static List<Video> videos = new List<Video>();
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        //escribe un programa que cree de 3 a 4 videos, establezca los valores adecuados y, para cada uno, 
        // agregue una lista de 3 a 4 comentarios (con el nombre y el texto del comentarista). 
        // Coloca cada uno de estos videos en una lista. 
        // Si no puedo ingresarlos. Que se generen al azar de una lista de comentarios, usuarios y nombres de videos. 
        // Las posibilidades son diversas

        //class Video (registre el título, el autor y la duración (en segundos) del video.)
        //Cada video también debe almacenar una lista de comentarios y un método para devolver el número de comentarios. 

        //class comment  registre tanto el nombre de la persona que lo comentó como su texto.

        //Luego, haz que tu programa itere por la lista de videos y, para cada uno, muestre el título, el autor, la duración 
        // y el número de comentarios (del método) y, finalmente, enumere todos los comentarios de ese video. Repite esta 
        // visualización para cada video de la lista. No necesitas que se llame a un video en particular, solo que el programa muestre todos los datos

        Video video1 = new Video();
        {
            video1._title = "Original vs Fake Adidas Samba";
            video1._author = "Fredy Flows";
            video1._time = "5.5 min";
            video1._comments = new List<Comment>
            {
                new Comment{_name="@Roy52202", _comment="Quality is subjective, since if a product meets the requirements and satisfies your particular needs, it is quality."},
                new Comment{_name="@gutierrez2000", _comment="Excellent video!!!"},
                new Comment{_name="@faustomunoz", _comment="Great video! Better lighting would be much better, to see more details!"}
            };
        }
        ;
        videos.Add(video1);
        Video video2 = new Video();
        {
            video2._title = "Why Adidas Superstar is a 50 year Icon - (CUT IN HALF)";
            video2._author = "Rosse Anv";
            video2._time = "11.05 min";
            video2._comments = new List<Comment>
            {
                new Comment{_name="@Red52202", _comment="I used to work in a factory that make millions of these shoes."},
                new Comment{_name="@gonzales1999", _comment="Great video!!!"},
                new Comment{_name="@gracemarconi", _comment="Appreciate the Shoutout brotha 😎😎😎 thank you"}
            };

        }
        ;
        videos.Add(video2);
        Video video3 = new Video();
        {
            video3._title = "Top 5 ADIDAS Shoes You SHOULD Own in 2025";
            video3._author = "Josh Dominic";
            video3._time = "7.5 min";
            video3._comments = new List<Comment>
            {
                new Comment{_name="@pielucas439", _comment="Excellent video!"},
                new Comment{_name="@Moondoggy1941", _comment="Thanks!!!"},
                new Comment{_name="@giovanny18", _comment="Great video!"}
            };

        }
        ;
        videos.Add(video3);

        PrintVideos(videos);


    }
    public static void PrintVideos(List<Video> videos)
    {
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author + "Duration: " + video._time);
            Console.WriteLine("Total Comments: " + video.CountComments(video._comments));
            int n = 0;
            foreach (var comment in video._comments)
            {
                n++;
                Console.WriteLine("Comment " + n + ".- " + comment._name + " : " + comment._comment);
            }

        }
    }

}