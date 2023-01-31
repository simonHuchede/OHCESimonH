using OHCE.Console;
using OHCESimonH;
using System.Globalization;

var ohce = new Ohce(new SystemLangProxy().GetSystemLangProxy(CultureInfo.InstalledUICulture.TwoLetterISOLanguageName), new SystemTimePériodeJournéeAdapter().GetPériode(DateTime.Now.Hour));


Console.WriteLine(ohce.DireBonjour(Console.ReadLine() ?? String.Empty));

Console.WriteLine("Entrez un mot pour savoir si c'est un palindrome");

Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? String.Empty));

Console.WriteLine(ohce.DireAuRevoir(Console.ReadLine() ?? String.Empty));