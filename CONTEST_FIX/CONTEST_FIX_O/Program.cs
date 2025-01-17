﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTEST_FIX_O
{
    internal class Program
    {
        private static bool BinarySearch_BOOL(List<int> arr, int el)
        {
            int l = 0, r = arr.Count - 1, middle = (1 + r) / 2;
            while (l <= r)
            {
                if (arr[middle] > el)
                    r = middle - 1;
                if (arr[middle] < el)
                    l = middle + 1;
                if (arr[middle] == el)
                    return true;
                middle = (l + r) / 2;
            }
            return false;
        }
        static void Main(string[] args)
        {
            string[] STUD_REPLIC = Console.ReadLine().Split(' ');
            int N = int.Parse(STUD_REPLIC[0]);
            int M = int.Parse(STUD_REPLIC[1]);
            List<int> NAME_STUDENTS = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToList();
            List<int> DEC_VIOCE = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToList();
            NAME_STUDENTS.Sort();
            for(int i = 0; i < DEC_VIOCE.Count; i++)
            {
                if (BinarySearch_BOOL(NAME_STUDENTS, DEC_VIOCE[i]))
                {
                    Console.WriteLine("Yes, teacher!");
                }
                else
                {
                    Console.WriteLine("Silence");
                }
            }
            Console.ReadKey();
        }
    }
}