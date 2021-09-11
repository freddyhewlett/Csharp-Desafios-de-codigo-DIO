/*Desafio
Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.
*/

using System;

class ConversaoTempo 
{
    static void Main(string[] args) 
    {
        int timeInSeconds = int.Parse(Console.ReadLine());

        int hours = timeInSeconds / 3600;
        timeInSeconds -=  (hours*3600);
        int minutes = timeInSeconds / 60;
        int seconds = timeInSeconds - (minutes*60);

        Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }