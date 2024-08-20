/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir
as informações básicas do personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial,
classe, e raça do personagem e exiba esses dados no console.

@Lista: 02 - Condicionais
@Autor: João Lucas Saraiva Farias 
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
string cla;
int defesa, agilidade;

Console.WriteLine("Informe a classe do personagem: ");
cla = Console.ReadLine();

Console.WriteLine("Informe o valor da defesa: ");
int.TryParse(Console.ReadLine(), out defesa);

Console.WriteLine("Informe a penalidade de agilidade: ");
int.TryParse(Console.ReadLine(), out agilidade);

if (cla == "guerreiro")
{
    if (defesa > 50 && agilidade < 20)
    {
        Console.WriteLine("Armadura adequada");
    }
}
    if (cla == "arqueiro")
    {
        if (defesa > 30 && agilidade < 10)
        {
            Console.WriteLine("Armadura adequada");
        }
    }
    if (cla == "mago")
    {
        if (defesa > 20 && agilidade < 40)
        {
            Console.WriteLine("Armadura adequada");
        }
    }
        else
        {
            Console.WriteLine("Armadura inadequada");
        }
    }
}
