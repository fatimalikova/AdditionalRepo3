namespace DeligatePractice
{
    internal class Program
    {
        public delegate bool NumberMethod(int number);
        static void Main(string[] args)
        {
            Sum(IsEven, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Sum(IsOdd, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            NumberMethod method = IsEven;
            method(1);

        }

        #region Simple Practice
        //public static void SumOdd(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (var number in numbers)
        //    {
        //        if (IsOdd(number))
        //        {
        //            sum += number;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}
        //////////////////////////////////////////////////////
        //public static bool IsEven(int number)
        //{
        //    return number % 2 == 0;
        //}
        //public static bool IsOdd(int number)
        //{
        //    return number % 2 != 0;
        //}
        /////////////////////////////////////////////////////
        //public static void SumEven(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (var number in numbers)
        //    {
        //        if (IsEven(number))
        //        {
        //            sum += number;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //} 
        #endregion

        public static void Sum(NumberMethod method,params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                if (method(number))
                {
                    sum += number;
                }
            }
            Console.WriteLine(sum);
        }

        ////////////////////////////////////////////////////
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        ///////////////////////////////////////////////////
    }
}
