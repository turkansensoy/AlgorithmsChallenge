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
            int[,] adjacencyMatrix = new int[33, 33];
            List<string> friends = new List<string>();

            //matris oluşturulur 
            for (int i = 0; i < 32; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    adjacencyMatrix[i, j] = 0;
                }
            }
            
            //txt dosyasında ki veriler diziye alınır
            string[] allLines = System.IO.File.ReadAllLines(@"C:\Users\türkan şensoy\Desktop\arkadas.txt");

            //Ayrac belirtilip geçici olarak oluşturulan alanlara değerler çekilir.
            var query = from line in allLines
                        let data = line.Split(';') //Ayraç;
                        select new
                        {
                            name = data[0],
                            other = data[1],

                        };
            foreach (var item in query)
            {
                friends.Add(item.name);
                
            }  

            foreach (var item in query)
            {
                List<string> myFriends = new List<string>();

                var index = friends.IndexOf(item.name);
                //Console.WriteLine("{0},{1}", item.name,index);     
                
                string[] otherName = item.other.Split(',');   
                foreach (var item1 in otherName)
                {
                    myFriends.Add(item1);
                }
                 
                for (int i = 0; i < 33; i++)
                { 
                    for (int j = 0; j<otherName.Length; j++)
                    {
                        if (Array.Equals(friends[i], myFriends[j]) == true)
                        {

                            //Console.WriteLine(" {0}, {1}", myFriends[j],i);
                            adjacencyMatrix[index,i] = 1;
                        }      
                    }               
                }
            }

            for (int i = 0; i < 33; i++)
            {
                for (int j = 0; j < 33; j++)
                {
                    Console.Write(adjacencyMatrix[i, j] + " ");
                }
                Console.WriteLine("");
            }

        }
        
    }
}

