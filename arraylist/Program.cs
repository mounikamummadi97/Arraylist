// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace collection
{
    public class collections
    {
        
        public static void Main(string[] args)
        {
            ArrayList al = new ArrayList(2);
            Console.WriteLine(al.Capacity);
            //Console.WriteLine(al.Count);
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add(200); al.Add(300); al.Add(400);  
            Console.WriteLine(al.Capacity);
            //Console.WriteLine(al.Count);
            al.Insert(3,350);
            //al.Remove(200);
            al.RemoveAt(1);

            foreach (object obj in al)
            {
                Console.Write(obj + " ");
                Console.WriteLine();
                
            }


        }
    }
   
}

    
