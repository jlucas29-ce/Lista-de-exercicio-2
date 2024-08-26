/*-------------------------------------------------------------------
Questão 3: Loja de Poções
* Contextualização: Em uma loja de poções mágicas, o jogador pode comprar poções que
aumentam sua vida, mana ou resistência. O preço das poções é fixo: Vida custa 10 moedas,
Mana custa 15 moedas, e Resistência custa 20 moedas. Dependendo da classe do jogador, há
um desconto aplicável.
* Comando: Crie um programa que receba a classe do jogador (Guerreiro, Mago, Paladino), o tipo
de poção (Vida, Mana, Resistência), e a quantidade que deseja comprar. Calcule o preço total
das poções, aplicando o desconto correspondente:
* Guerreiro recebe 10% de desconto na compra de poções de Vida.
* Mago recebe 15% de desconto na compra de poções de Mana.
* Paladino recebe 20% de desconto na compra de poções de Resistência.
* Exiba o preço total com e sem desconto.
@Lista: 02 - Condicionais
@Autor: João Lucas Saraiva Farias 
@Data: 21/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    public static void Main(string[] args)
    {
            string classe, porcao;
            int quant, resu;
            double total;
            
        Console.WriteLine ("Informe a classe do jogador:(guerreiro, mago, paladino)");
        classe = Console.ReadLine();
        
        Console.WriteLine ("Informe a poção que deseja comprar:(Vida, Mana, Resistência)");
        porcao = Console.ReadLine();
        
        Console.WriteLine ("Informe a quantidade de porção:");
        int.TryParse(Console.ReadLine(), out quant);
        
        if(porcao == "vida")
        {
            resu = 10 * quant;
            Console.WriteLine($"Resultado sem desconto:{resu}");
        }
        if(porcao == "mana")
        {
        resu = 15 * quant;
        Console.WriteLine($"Resultado sem desconto:{resu}");
        }
         if(porcao == "resistencia")
        {
        resu = 20 * quant;
        Console.WriteLine($"Resultado sem desconto :{resu}");
        }
        if(classe == "guerreiro" && porcao == "vida")
        {
            resu = (10 * quant);
            total = resu - (resu * 0.1);
            Console.WriteLine($"O resultado sem desconto:{resu}");
            Console.WriteLine($"Resultado com descoonto:{total}");
        }
        if(classe == "mago" && porcao == "mana")
        {
            resu = (15 * quant);
            total = resu - (resu * 0.15);
             Console.WriteLine($"O resultado sem desconto:{resu}");
            Console.WriteLine($"Resultado com descoonto:{total}");
        }
        if(classe == "paladino" && porcao == "resistencia")
        {
            resu = (20 * quant);
           total = resu - (resu * 0.2);
             Console.WriteLine($"O resultado sem desconto:{resu}");
           Console.WriteLine($"Resultado com descoonto:{total}");
        }
     }
        
}
