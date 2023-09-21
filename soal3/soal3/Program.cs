namespace soal3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(perkaliansederhana(5, 4));

        }
        public static int perkaliansederhana(int j, int k)
        {
            int hasil = 0;
            while (j > 0)
            {
                hasil += k;
                j--;
            }
            return hasil;
        }
    }
}