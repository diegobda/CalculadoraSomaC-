using System;

class programa{

    static void Main(){
        int v1, v2, soma;

        Console.Write("Digite o primeiro valor: ");
        v1=int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        v2=int.Parse(Console.ReadLine());
        soma=v1+v2;
        Console.WriteLine("A soma de {0} mais {1} e igual {2}" ,v1 ,v2, soma);
        break;
    }
}
