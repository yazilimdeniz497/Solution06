Console.WriteLine("Adınızı Giriniz: ");
string firstname=Console.ReadLine();
Console.WriteLine("Soyadinizi Giriniz: ");
string lastname=Console.ReadLine();
string welcome1 = "Merhaba" + firstname + " " + lastname + ".";

string welcome2 = String.Concat("Sayin", firstname, lastname);
Console.WriteLine(welcome1);
Console.WriteLine(welcome2);
Console.ReadKey();