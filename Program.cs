// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");

string[] classification = new[] {"polaretti", "pasta", "pizza", "limone", "gelato", "carne", "ostriche", "champagne", "verdura", "patate"};

Console.WriteLine("Lunghezza della classifica " + classification.Length);

for (int i = 0; i < classification.Length; i++){
    Console.WriteLine(i+1 + ". " + classification[i]);
}

Console.WriteLine("My favourite dish is " + classification[0]);

Console.WriteLine("The last is " + classification[classification.Length-1]);

