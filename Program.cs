using System;

namespace karar_yapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            // int time = DateTime.Now.Hour; // O anki saati alıyoruz.
            int time = 10; // O anki saati alıyoruz.

            // En çok kullanılan ve detaylı olmasından dolayı daha çok tercih edilen kod bloğu budur.

            if(time >=6 && time<11) // Koşul sağlanırsa alttaki kod bloğunu çalıştırır.
                Console.WriteLine("Günaydın..."); // Kod bloğu
            else if (time <= 18)
                Console.WriteLine("İyi Günler...");
            else
                Console.WriteLine("İyi Geceler..."); // Hiçbir koşul sağlanmazsa bu çalışır.
            

            // Bu karar kod bloğu genelde sadece if ve else'in kullanıldığı karar bloklarında tercih edilir. 
            // Tabiki uzun karar yapıları içinde kullanılır ama diğerinde daha detaylı 
            // ve anlaşılır olması onu daha çok, büyük karar yapılarında kullanmaya itiyor.

            string sonuc = time <=18 ? "İyi Günler" : "İyi Geceler";

            // Yukarıdaki if ifadesini tek satırda yazmış olduk.
        
            sonuc = time >=6 && time<11 ? "Günaydın" : time <=18 ? "İyi Günler" : "İyi Geceler"; 

            Console.WriteLine(sonuc);
        }
    }
}

