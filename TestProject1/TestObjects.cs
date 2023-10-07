namespace TestProject1
{
    internal class TestObjects
    {
        public bool IsFibonacciMember(int n)
        {
            bool result = false;

            //List<int> fibonacciSeries = new List<int>();

            //PopulateFibonacci(ref fibonacciSeries, ref n);

            //return fibonacciSeries.Contains(n);

            int f1 = 0;
            int f2 = 1;
            int f3 = 0;

            if (n == 0 || n == 1)
            {
                result = true;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    f3 = f1 + f2;

                    if (f3 == n)
                    {
                        result = true;
                        break;
                    }
                    else if (f3 > n)
                    {
                        break;
                    }
                    else
                    {
                        f1 = f2;
                        f2 = f3;
                    }
                }
            }

            return result;
        }

        private void PopulateFibonacci(ref List<int> targetList, ref int limit)
        {
            for (int i = 0; i <= limit; i++)
            {
                targetList.Add(RecursiveFibonnaci(i));
            }

            //int f1 = 0;
            //int f2 = 1;
            //int f3 = 0;

            //targetList.Add(f1);
            //targetList.Add(f2);

            //for (int i = 0; i < limit; i++)
            //{
            //    f3 = f1 + f2;
            //    f1 = f2;
            //    f2 = f3;
            //    targetList.Add(f3);
            //}
        }

        private int RecursiveFibonnaci(int n)
        {
            int result = 0;

            switch (n)
            {
                case 0:
                    result = 0;
                    break;

                case 1:
                    result = 1;
                    break;

                default:
                    result = RecursiveFibonnaci(n - 1) + RecursiveFibonnaci(n - 2);
                    break;
            }

            return result;
        }
    }
}