﻿using System;

namespace GuidedProject1
{
    class Project1
    {
        static void Main(string[] args)
        {
            // initialize variables - graded assignments 
            int currentAssignments = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            int sophiaSum = 0;
            int nicolasSum = 0;
            int zahirahSum = 0;
            int jeongSum = 0;

            sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

            Console.WriteLine("Sophia: " + sophiaSum);
            Console.WriteLine("Nicolas: " +  nicolasSum);
            Console.WriteLine("Zahirah: " + zahirahSum);
            Console.WriteLine("Jeong: " + jeongSum);

            decimal sophiaScore;
            decimal nicolasScore;
            decimal zahirahScore;
            decimal jeongScore;

            sophiaScore = (decimal) sophiaSum / currentAssignments;
            nicolasScore = (decimal) nicolasSum / currentAssignments;
            zahirahScore = (decimal) zahirahSum / currentAssignments;
            jeongScore = (decimal) jeongSum / currentAssignments;

            Console.WriteLine("Student Grade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
            Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
            Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
            Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");


        }
    }
}
