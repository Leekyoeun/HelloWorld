using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World");

             string name = "Alex";
             Console.WriteLine(name);*/
             //--------------------
            /*int n1 = 1;
            int n2 = 2;
            int n3 = 3;
            //....
            int n100 = 100;*/
            int[]n=new int[100];
            //n[0] = 1;
            //n[1] = 2;
            for(int i=0; i<n.Length; i++)
            {
                n[i] = i + 1;
            }
            int x = n[10];
            //배열을 함수에 전달
            static void PrintArray(int[] arr)
            {
                for(int i=0; i<arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
