using OHCESimonH;


    var ohce = new Ohce();
    Console.WriteLine("Entrez un mot pour le voir en miroir");
    Console.WriteLine(ohce.Miroir(Console.ReadLine() ?? String.Empty));
