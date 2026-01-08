namespace DeligatePractice
{
    internal class Program
    {
        public delegate bool NumberMethod(int number);
        public delegate T ResultMethod<T>(T param);

        public delegate U GenericMethod<in T,out U>(T parameter);
        static void Main(string[] args)
        {
            Sum((s) => s % 2 == 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Sum(delegate (int s)
            { return s % 2 != 0; }, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            NumberMethod method = IsEven;
            method += IsOdd;
            //method(1);
            //method.Invoke(2);

            //method += delegate (int number)
            //{
            //    return number > 5;
            //};

            //method += (s) => s < 5;
            //method(2);

            //ResultMethod<int> resultMethod = delegate (int number)
            //{
            //    return number * number;
            //};
            //ResultMethod<string> resultMethod1 = (s) => s + " Hello";
            //Console.WriteLine(resultMethod1("Test"));
            //Console.WriteLine(resultMethod(3));

            //GenericMethod<int, string> genericMethod = (s) => s.ToString() + " Generic Method";
            //Console.WriteLine(genericMethod(5));
            //Console.WriteLine(genericMethod(10));
            //Console.WriteLine(genericMethod(20));
            //Console.WriteLine(genericMethod(30));

             

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
