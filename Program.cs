﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 2, 3, 4, 5, 6, 6, 6, 6, 7, 7, 7 };
            for(int i = 0; i < a.Length; i++)
            {
                int count = 0;
                for(int j=0;j<a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{a[i]}. {count}");

            }
        }
    }
}
