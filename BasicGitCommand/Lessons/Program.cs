namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tapşırıq: 2 array verilmişdir, 2ci arraydəki bütün elementlər həm də 1cidə varsa , true əks halda false çap olunsun.


            int[] firstArr = { 211, 9, -6, 12, 34, 56, 32, 5, 19 };
            int[] secondArr = { 19, -6, 32 };

            bool result = false;
            int count = 0;

            for (int i = 0; i < firstArr.Length; i++)
            {
                for (int j = 0; j < secondArr.Length; j++)
                {
                    if (firstArr[i] == secondArr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            if (count == secondArr.Length) 
                result = true;

            Console.WriteLine(result);
        }
    }
}
