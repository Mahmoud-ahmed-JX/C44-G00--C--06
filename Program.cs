using System.Diagnostics.CodeAnalysis;

namespace asmnt6
{
    internal class Program
    {
        #region Q1

        #region passing by value
        public static void swap01(int x, int y)
        {
            int temp=x; x=y; y=temp;
        }
        #endregion

        #region passing by reference
        public static void swap02(ref int x,ref int y)
        {
            int temp = x; x = y; y = temp;
        }
        #endregion
        #endregion

        #region Q2
        #region passing by value
        public static void change01(int[] arr) {
            arr[0] = 100;
        }
        #endregion

        #region passing by reference
        public static void change02(int[] arr)
        {
            arr[0] = 100;
        }
        #endregion
        #endregion

        #region Q3
        //Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        public static void Q3(int x,int y,out int sum,out int sub)
        {
            sum = x + y;
            sub=x- y;
        }
        #endregion

        #region Q4
        /*Write a program in C# Sharp to create a function to calculate the sum of
            the individual digits of a given number.*/

        public static int Q4(int num) {
            int sum= 0;
            while (num > 0) {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        #endregion

        #region Q5
        /*Create a function named "IsPrime", which receives an integer number
        and retuns true if it is prime, or false if it is not:*/
        public static bool IsPrime(int num) {
            bool flag = true;
            for (int i = 2; i < num; i++) {
                if (num % i == 0) {  flag = false; break; } 
            }
            return flag;
        }
        #endregion

        #region Q6
        /*Create a function named MinMaxArray, to return the minimum and
        maximum values stored in an array, using reference parameters*/
        public static int[] MinMaxArray(int[] array) {
            int max = int.MinValue;
            int min= int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
                if(min> array[i]) min = array[i];
            }
            return [max, min];
        }
        #endregion

        #region Q7
        /*Create an iterative (non-recursive) function to calculate the factorial
        of the number specified as parameter*/
        public static void fact(int num)
        {
            int fact = num;
            for (int i = num-1; i > 0; i--) {
                fact *= i;
            }
            Console.WriteLine($"factorial = {fact}");
        }
        #endregion

        #region Q8
        /*Create a function named "ChangeChar" to modify a letter in a certain
        position (0 based) of a string, replacing it with a different letter*/
        public static void ChangeChar(ref string s,int pos,char newChar)
        {
            string temp="";
            for (int i = 0; i < s.Length; i++) { 
                if(i == pos)
                {
                    temp += newChar;
                }
                else
                {
                    temp += s[i];
                }
            }
            s = temp;
        }
        #endregion

        
        static void Main(string[] args)
        {

            #region Q1 sol
            /*Explain the difference between passing (Value type
            parameters) by value and by reference then write a suitable c#
            example.*/
            //----------------------------------------
            //int x = 5, y = 10;

            /*1-passing by value
             * it makes a copy from the data and stores it in the stack
             * doesn't change the original data
              --exapmle
             */
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //swap01(x, y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //no changes have been done in the x and y even after calling swap01 function 
            //this is passing by value


            /*
            * 2-passing by reference
            * it takes the address of stack and changes the data in it
            * makes change in the original data
            --example
            */


            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //swap01(x, y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //the values of x , y have been changed because we passed by reference
            #endregion

            #region Q2 sol
            /*Explain the difference between passing (Reference type
            parameters) by value and by reference then write a suitable c#
            example.*/
            //int[] arr = { 1, 2, 3 };
            /*-passing by value
             * due to its a reference type passing by value will change the value on the original data
             
             */
            //Console.WriteLine(arr[0]);
            //change01(arr);
            //Console.WriteLine(arr[0]);
            //the value changed after calling the function

            /*-passing by reference
             * due to its a reference type passing by reference will change the value on the original data
             
             */

            //Console.WriteLine(arr[0]);
            //change02(arr);
            //Console.WriteLine(arr[0]);
            //it changed too
            /*
             the main deference between the two types
            --if you created a new obj in the function
        --passing by value case
            the original data will not change

        --passing by reference case
            the original data will change
             */
            #endregion

            #region Q3 sol
            //int sum, sub;
            //Q3(10, 5, out sum, out sub);
            //Console.WriteLine($"sum = {sum} , sub = {sub}");

            #endregion

            #region Q4 sol
            //Console.WriteLine(Q4(25));
            #endregion

            #region Q5 sol
            //Console.WriteLine( IsPrime(19));
            #endregion

            #region Q6 sol
            //int[] res;
            //  res = MinMaxArray([1, 2, 3, 4, 5, 6]);
            //Console.WriteLine($"the max num = {res[0]}");
            //Console.WriteLine($"the min num = {res[1]}");

            #endregion

            #region Q7 sol
            //fact(5);
            #endregion

            #region Q8 sol
            //string s = "hello";
            //ChangeChar(ref s,2,'#');
            //Console.WriteLine(s);
            #endregion


        }
    }
}
