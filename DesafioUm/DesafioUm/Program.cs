// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
int idadeMinima = 18;
int maximoTentativas = 3;
int tentativas = 1;
bool permitido = true;

while (permitido)
{
    Console.WriteLine("Informe sua idade");
    var valor = Console.ReadLine();

    if (!Regex.IsMatch(valor, @"^\d+$"))
    {
        Console.WriteLine("Informe um numero valido!");
        continue;
    }
    
    int idade = Convert.ToInt32(valor);
    tentativas++;

    var maiorIdade = idade >= idadeMinima;
    var mensagem = maiorIdade
        ? "Voce pode tirar habilitacao!"
        : "Voce pode nao pode tirar habilitacao!";
    
    Console.WriteLine(mensagem);
    permitido = !maiorIdade && tentativas <= maximoTentativas;
}

Console.WriteLine("Encerrou!"); 
Console.ReadLine();