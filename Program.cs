Console.WriteLine("[___[ F O R C A ]___]");



Console.WriteLine("Digite a palavra:");
string palavra = Console.ReadLine()!;



Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine()!
.Trim()
.Substring(0, 1)
.ToLower();



bool letraExiste = palavra
.ToLower()
.Contains(letra);



Console.WriteLine($"\nA letra \"{letra}\" {(letraExiste ? "existe" : "não existe")} na palavra -> {palavra}");
