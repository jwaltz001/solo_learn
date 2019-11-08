using System;
using System.Collections.Generic;

namespace code_wars
{
    class Program
    {
        //You are going to be given an array of integers.
        //find an index N where the sum of the integers to the left of N is equal to the sum of the integers to the right of N.
        //If there is no index that would make this happen, return -1.
        public static int FindEvenIndex(int[] arr, int n = 0)
        {
            //Console.WriteLine(n);
            if (n == arr.Length - 1)
            {
                return -1;
            }
            //Declare variables
            int sumLeft = 0;
            int sumRight = 0;
            //sum up right and left
            for (int i = 0; i < n; i++)
            {
                sumLeft += arr[i];
            }
            //Console.WriteLine(sumLeft);
            for (int i = n + 1; i < arr.Length; i++)
            {
                sumRight += arr[i];
                
            }
            //Console.WriteLine(sumRight);
            //check if sum of right and left are equal
            if (sumLeft == sumRight)
            {
                return n;
            }
            n++;
            return FindEvenIndex(arr, n);
            //else
            //{
            //    return FindEvenIndex(arr, n++);
            //}

        }

        static void  Main(string[] args)
        {
            Console.WriteLine(FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
            Console.WriteLine(FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            //int a = 7;
            //int b = 5;
            ////declare array to store remainders(bits)
            //List<int> remainderArr = new List<int>();
            ////calculate the sum
            //int sum = a + b;
            ////store sum as "quotient" to start while loop
            //int quotient = sum;

            ////Run while loop until quotient is 0
            //while (quotient > 0)
            //{
            //    //find the remainder of dividing by 2 and add it to the remainders list
            //    //(must be in reverse order so the newest one last)
            //    int remainder = quotient % 2;
            //    remainderArr.Insert(0, remainder);

            //    //find the whole whole int of dividing by 2 and store as new quotient
            //    quotient = quotient / 2;
            //}
            ////return the remainder array as a string
            ////store first value as a string
            //string answer = string.Join("", remainderArr.ToArray());
            //Console.WriteLine(answer);
        }
    }
}



//using System;

//namespace solo_learn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            do{
//                Console.Write("x=");
//                string str = Console.ReadLine();
//                if (str == "q")
//                    break;
//                int x = Convert.ToInt32(str);
//                Console.Write("y=");
//                int y = Convert.ToInt32(Console.ReadLine());
//                int sum = x + y;
//                Console.WriteLine("Result:{0}", sum);
//            }
//            while (true);
//        }
//    }
//}
