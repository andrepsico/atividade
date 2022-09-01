using System;

class Exercicio20
{
    public static void Main(string[] args){

        double pesoQuilo, altura, IMC;

          Console.Write("Digite seu peso em Kg: \n>> ");
             pesoQuilo = Convert.ToDouble(Console.ReadLine());

        
        
             Console.Write("Digite sua altura em Metros (Com virgula): ");
        altura = Convert.ToDouble(Console.ReadLine());

IMC = pesoQuilo / (altura * altura);

                     if ( IMC >= 0 && IMC <= 18.5)
        {
            Console.Write(" Abaixo do peso!");
                      }else if ( IMC > 18.5 && IMC <= 25)
        {
            Console.Write(" Peso ideal!");
                      }else if ( IMC > 25 && IMC <= 30)
        {
            Console.Write("Sobrepeso!");
                      }else if ( IMC > 30 && IMC <= 40)
        {
            Console.Write("Obesidade!");
        }

    }
}