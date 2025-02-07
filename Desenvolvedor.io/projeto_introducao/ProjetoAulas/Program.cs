/*
Random random = new Random();
int numeroAleatorio = random.Next(1, 101);
Console.WriteLine(numeroAleatorio);

bool req = numeroAleatorio > 50;
Console.WriteLine(req);

string status = numeroAleatorio > 50 ? "Ativo" : "Inativo";

Console.WriteLine(status);
*/

/*
var res = SomaValores("João", 20);
Console.WriteLine(res);

string SomaValores(string a, int b)
{
    return "Meu nome é "+ a + " e tenho " + b + " anos de idade.";
}
*/

using System.Collections;
/*
var arrayList = new ArrayList { 1, "string", true };
var arrayTipado = new int[3] { 1, 2, 3 };
Array.Resize(ref arrayTipado, 100);

arrayTipado[1] = 10; //Alterar indice
arrayTipado[99] = 30; 

arrayList.RemoveAt(2);
arrayList = new ArrayList(); //Limpa a lista
arrayList.Clear(); //Tbm limpa a lista

//Console.WriteLine(arrayList[0]);
//Console.WriteLine(arrayList[1]);
//Console.WriteLine(arrayList[2]);

foreach (var variable in arrayTipado)
{
    Console.WriteLine(variable);
}
*/

/*var lista = new List<string>(10)
{
    "Joe","Smith"
};
lista.Add("Karina");
lista.Add("Vitor");

Console.WriteLine(lista[1]);
lista.RemoveAt(1);

foreach(var nome in lista){
    Console.WriteLine(nome);
}*/

/*
var dicionario = new Dictionary<int, string>(){
    {1, "João"},
    {2, "Karina"},
    {3, "Vitor"}
};
var dicionarioString = new Dictionary<string, string>(){
    {"key", "value"},
    {"nome", "João"},
    {"curso", "ADS"},
    {"cidade", "Curitiba"}
};
dicionario.Add(4, "Teste");
dicionario[50] = "Lionel";

foreach(var nome in dicionarioString){
    Console.WriteLine(nome.Value);
}

//var nome1 = dicionarioString["curso"];
//Console.WriteLine(nome1);
*/

/*
var queue = new Queue<string>();
queue.Enqueue("João");
queue.Enqueue("Karina");

queue.Dequeue();

//Console.WriteLine(queue.Peek());

foreach(var nome in queue){
    Console.WriteLine(nome);
}
*/

var stack = new Stack<string>();
stack.Push("João");
stack.Push("Maria");
stack.Push("Karina");
stack.Push("Vitor"); 


foreach(var nome in stack){
    Console.WriteLine(nome);
}
Console.WriteLine("---------------------");

Console.WriteLine(stack.Pop());//Vitor
Console.WriteLine(stack.Peek());//Karina


Console.WriteLine("------Loop Aqui------");
foreach(var nome in stack){
    Console.WriteLine(nome);
}
