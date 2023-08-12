namespace Item1Practice
{
    internal class Item1PracticeSolution
    {
        /* Write a C# method which accepts two integer parameters, x and y,
        * and returns true if x is less than y^2 or if y is odd.
        * 
        * Examples of required functionality:
        *   questionOne(9,3) should return true
        *   questionOne(16,4) should return false
        *   questionOne(5,7) should return true
        */
        public static bool questionOne(int x, int y)
        {
            return false;
        }

        /* Write a C# method which accepts a single integer, x, and returns
         * the string, "Foo", if it is a multiple of 5, "Bar", if it is a 
         * multiple of 7, and "FooBar!", if it is a multiple of both 5 and 7.
         * 
         * Examples of required functionality:
         *   questionTwo(2) should return ""
         *   questionTwo(15) should return "Foo"
         *   questionTwo(21) should return "Bar"
         *   questionTwo(35) should return "FooBar!"
         */
        public static string questionTwo(int x)
        {
            return "";
        }

        /* Write a C# method which accepts two chars, a and b, and returns 
         * a char array containing every letter between the provided chars
         * including those provided. If none of these conditions are true,
         * the function should return an empty string.
         * 
         * Examples of required functionality:
         *   questionThree('a','e') should return ['a','b','c','d','e']
         *   questionThree('h','c') should return ['c','d','e','f','g','h']
         */
        public static char[] questionThree(char a, char b)
        {
            return null;
        }

        /* Write a C# method which accepts an integer, x, and a list of integers,
         * l, and throws an exception if x is negative or if y contains a zero.
         * Both exceptions should be based on custom exception classes (provided below)
         * 
         * You do not need to catch the exceptions, just have your function throw them.
         * If no exceptions are raised, your function should return nothing.
         * 
         * Examples of required functionality:
         *   questionFour(-5,{2,4,0,8}) should throw NegativeNumberException
         *   questionFour(10,{2,4,8}) should not do anything
         */

        // Custom exception 1
        public class NegativeNumberException : Exception
        {
            public NegativeNumberException(string message) : base(message) { }
        }

        // Custom exception 2
        public class ZeroInListException : Exception
        {
            public ZeroInListException(string message) : base(message) { }
        }

        public static void questionFour(int x, List<int> l)
        {
        }

        /* Write a C# method which accepts an integer, x, and returns a stack with 
         * x many lowercase characters in alphabetical order. The pop operation 
         * should return the later letter in the alphabet.
         * 
         * An input of zero 
         * 
         * Examples of required functionality:
         *   questionFive(5) should return ['e','d','c','b','a']
         *   questionFive(3) should return ['c','b','a']
         */

        public static Stack<char> questionFive(int x)
        {
            return null;
        }

        // You can call and test your functions by writing code in the Main() method
        // Remember: nothing in your Main method gets marked
        // *Only* the code in your functions (above) will be marked
        public static void Main()
        {
        }



    }
}