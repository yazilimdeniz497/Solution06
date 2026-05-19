namespace _06_02_StringandChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for(int i = 65; i < 90; i++)
            {
                char lettercode = (char)i;
                Console.WriteLine(lettercode+ " ");
            }
           Console.ReadKey();
        }
    }
}
