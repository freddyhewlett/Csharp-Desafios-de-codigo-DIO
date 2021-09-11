/*Desafio
Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.  Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas(...).

Entrada
A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.

Saída
Imprima o nome do animal correspondente à entrada fornecida.
*/

using System;
using System.Text;

class Animal 
{
    public static void Main (string[] args) 
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string c = Console.ReadLine();

        if ((a == "vertebrado") && (b == "ave") && (c == "carnivoro" )) 
            Console.WriteLine("aguia");
        if ((a == "vertebrado") && (b == "ave")  && (c == "onivoro")) 
            Console.WriteLine("pomba");
        if ((a == "vertebrado") && (b == "mamifero") && (c == "onivoro" )) 
            Console.WriteLine("homem");
        if ((a == "vertebrado") && (b == "mamifero")  && (c == "herbivoro")) 
            Console.WriteLine("vaca");
        if ((a == "invertebrado") && (b == "inseto") && (c == "hematofago" )) 
            Console.WriteLine("pulga");
        if ((a == "invertebrado") && (b == "inseto")  && (c == "herbivoro")) 
            Console.WriteLine("lagarta");
        if ((a == "invertebrado") && (b == "anelideo") && (c == "hematofago" )) 
            Console.WriteLine("sanguessuga");
        if ((a == "invertebrado") && (b == "anelideo")  && (c == "onivoro")) 
            Console.WriteLine("minhoca");
    }
}