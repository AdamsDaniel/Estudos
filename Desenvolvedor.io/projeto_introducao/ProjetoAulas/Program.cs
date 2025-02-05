Random random = new Random();
int numeroAleatorio = random.Next(1, 101);
Console.WriteLine(numeroAleatorio);

bool req = numeroAleatorio > 50;
Console.WriteLine(req);

string status = numeroAleatorio > 50 ? "Ativo" : "Inativo";

Console.WriteLine(status);