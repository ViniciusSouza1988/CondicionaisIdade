using System.ComponentModel.Design;

string nome;

Console.WriteLine("Digite o seu nome:");
nome = Console.ReadLine();


int idade;
Console.WriteLine("Digite a sua idade:");
idade = Convert.ToInt32(Console.ReadLine());


List<string> Sacola = new List<string>();
Sacola.Add("Heineken");

string[] produtos = new string[] { "Macarrão", "Arroz" };
Sacola.AddRange(produtos);


if (idade >= 18)
{
Console.WriteLine("O nome do usuário é: " + nome);
Console.WriteLine("A idade do usuário é: " + idade);
Console.WriteLine("A quantidade de itens na sacola é:" + Sacola.Count());
}
    

else
{
Console.WriteLine("O nome do usuário é: " + nome);
Console.WriteLine("A idade do usuário é: " + idade);
Console.WriteLine("A quantidade de itens na sacola é:" + produtos.Count());
}
    








