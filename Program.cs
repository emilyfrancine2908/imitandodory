
Console.Clear();

 Console.WriteLine("tradutor de baleês \n");
 Console.Write("Digite o texto a ser traduzido: ");

 string texto = Console.ReadLine()!;

 Console.WriteLine("\nA dory diria...\n");

 Console.WriteLine(texto
 .Replace("a" , "aaa")
 .Replace("i" , "iii")
 .Replace("u" , "uuu")
 .Replace("e" , "eee")
 .Replace("o" , "ooo")
 .Replace("a" , "aaa")
 .Replace("i" , "iii")
 .Replace("u" , "uuu")
 .Replace("e" , "eee")
 .Replace("o" , "ooo")
 );
 Console.WriteLine();