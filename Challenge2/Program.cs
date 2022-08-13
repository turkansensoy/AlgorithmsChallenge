using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] adjacencyMatrix = new int[32, 32];
            List<string> friends = new List<string>();

            //matris oluşturma 
            for (int i = 0; i <32; i++)
            {
                for (int j = 0; j <32; j++)
                {
                    adjacencyMatrix[i,j] = 0;
                }
            }
            //matris çıktı
            for (int i = 0; i < 32; i++)
            {
                for (int j = 0; j <32; j++)
                {
                    Console.Write(adjacencyMatrix[i, j] + " ");
                }
                Console.WriteLine("");
            }
            //txt dosyasında ki veriler diziye alınıyor.
            string[] allLines = System.IO.File.ReadAllLines(@"C:\Users\türkan şensoy\Desktop\arkadas.txt");
            List<string> names = new List<string>();
            //Ayrac belirtilip geçici olarak oluşturulan alanlara değerler çekiliyor.
            var query = from line in allLines
                        let data = line.Split(';') //Ayraç;
                        select new
                        {
                            //friend = data[0],
                            name = data[1],
                        };


            foreach (var item in query)
            {
                //friends.Add(item.friend);
                names.Add(item.name);
                //Console.WriteLine("{0} ", item.friend[6]);
            }
            Console.WriteLine(names[1]);
            var query1 = from line in names
                         let data = line.Split(',') //Ayraç;
                         select new
                         {
                             //friend = data[0],
                             name1 = data[0],
                         };
            foreach (var item in query1)
            {
                //friends.Add(item.friend);

                Console.WriteLine("{0} ", item.name1);
            }

        }
    }
}
