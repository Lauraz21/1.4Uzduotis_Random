namespace _1._4Uzduotis_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {

            foreach (int i in ReturnNumSum())
            {
            Console.WriteLine(i);
            }
         

        }
        public static List<int> ReturnNumSum()
        {
            Random random = new Random();

            List<int> list = new List<int>();


            for (int i = 0; i < 101; i++)
            {
                list.Add(random.Next(1, 7) + random.Next(1, 7));
            }

            return list;
        }
    }
}