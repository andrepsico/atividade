using System;

class Exercicio19
{
    static void Main(string[] args)
	{ 
        double valorImovel, salario, prestacao;
        
        
                      Console.WriteLine("Digite o valor do imovel desejado:");
         valorImovel = int.Parse(Console.ReadLine());

                     Console.WriteLine("Digite quanto voce ganha:");
         salario = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite em quantas prestacoes voce quer pagar:");
          prestacao = int.Parse(Console.ReadLine());

                     salario = salario * 0.70;
         prestacao = valorImovel / prestacao;
        
        if (prestacao > salario)
        {
            Console.WriteLine("Nao sera possivel comprar.");
        }else{
            Console.WriteLine("Sera possivel.");
        }

     
      Console.WriteLine("Digite Enter para sair..");
      Console.ReadLine();
    }
}
