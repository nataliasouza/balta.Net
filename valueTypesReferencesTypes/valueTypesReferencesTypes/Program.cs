﻿using System;

namespace valueTypesReferencesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x = 25;
             int y = x;

             Console.WriteLine(x);
             Console.WriteLine(y);

             x = 32;

             Console.WriteLine(x);
             Console.WriteLine(y); */

            var arr = new string[2];
            arr[0] = "Item 1";

            var arr2 = arr;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "Item 2 ";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);
        }
    }
}
