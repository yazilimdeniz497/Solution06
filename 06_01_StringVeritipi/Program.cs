namespace _06_01_StringVeritipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "merhaba";
            Console.WriteLine("ilk mesaj:"+message);
            string newMessage = message + " dünya";
            Console.WriteLine("ilk mesaj:" + message);
            Console.WriteLine("yeni mesaj:" + message);
            Console.WriteLine("mesajın ilk karakteri:"+message[0]);
            Console.WriteLine("mesajın son karakteri: " + message[message.Length - 1]);
            Console.WriteLine("mesajın karakterleri");
            foreach (char c in message) 
            { Console.WriteLine(c);
            }
            Console.WriteLine($"Büyük harfe çevirme:{message.ToUpper()} ");
            Console.WriteLine($"içinde dünya varmı:{message.Contains("Dünya")} "); ;
            Console.ReadKey();
        }
    }
}
