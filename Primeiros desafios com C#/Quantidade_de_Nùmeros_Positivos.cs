/*Desafio
Crie um programa que leia 6 valores. Você poderá receber valores negativos e/ou positivos como entrada, devendo desconsiderar os valores nulos. Em seguida, apresente a quantidade de valores positivos digitados.

Entrada
Você receberá seis valores, negativos e/ou positivos.

Saída
Exiba uma mensagem dizendo quantos valores positivos foram lidos assim como é exibido abaixo no exemplo de saída. Não esqueça da mensagem "valores positivos" ao final.
*/

using System;

class Positivos
{
    static void Main(string[] args)
    {
        int positivos = 0;
        
        for (int i = 1; i <= 6; i++)
        {
            double valor = double.Parse(Console.ReadLine());
            if (valor > 0.0)
                positivos ++;
        }

        Console.WriteLine(positivos + " valores positivos");
    }
}