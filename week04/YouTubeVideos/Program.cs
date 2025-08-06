using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
class Program
{
    static List<Video> entries = new List<Video>();
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
            video1._comments = new List<Video.Comment>
            {
                new Video.Comment{_name="@Roy52202", _comment="Quality is subjective, since if a product meets the requirements and satisfies your particular needs, it is quality."},
                new Video.Comment{_name="@gutierrez2000", _comment="Excellent video!!!"},
                new Video.Comment{_name="@faustomunoz", _comment="Great video! Better lighting would be much better, to see more details!"}
            };
        }
        ;
        Console.WriteLine(video1._title + "Author: " + video1._author);
        foreach (var comment in video1._comments)
        {
            Console.WriteLine(comment._name + " : " + comment._comment);

        }
    }
    /*public static void AddComment()
    {
        Comment
        return 16;
    }*/
}