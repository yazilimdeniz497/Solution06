using System.Text;

String Email = "zfercomert@gmail.com";
String[] endpoints = { "/home", "/products", "/usb-cable" };
string report1 = BuildReport(Email, endpoints, sessionId: "S-1001");
Console.WriteLine(report1);
string BuildReport(string email, string[] endpoints, string sessionId)
{
    var sb = new StringBuilder(capacity:256);
    sb.AppendLine($"Email:{email}");
    sb.AppendLine($"Session:{sessionId}");
    sb.AppendLine("Visited: ");
    foreach(var item in endpoints)
    {
        sb.AppendLine(item);
    }
    string report = sb.ToString();
    return report;

}
Console.ReadKey();