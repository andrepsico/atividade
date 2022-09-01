using System;

class program{
        public static void Main(String[] args){

            string nome;
            double salario, anostrabalhado;

            Console.Write(">> Digite o nome: \n>> ");
            nome = Console.ReadLine();

            Console.Write("\n>> Digite a quantos anos voce trabalha: \n>> ");
            anostrabalhado = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n>> Digite o seu salario para ver qual sera o aumento: \n>> ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (anostrabalhado <= 3 && anostrabalhado > 0)
            {
                salario = salario * 1.03;
                Console.WriteLine("\nSeu salário com aumento será de: R$" + salario + ".00");
            }else if (anostrabalhado > 3 && anostrabalhado <= 10)
            {
                salario = salario * 1.125;
                Console.WriteLine("\nSeu salário com aumento será de: R$" + salario + ".00");
            }else if (anostrabalhado > 10)
            {
                salario = salario * 1.20;
                Console.WriteLine("\nSeu salário com aumento será de: R$" + salario + ".00");
            }

            Console.WriteLine("\n>> Pressione Enter para sair... ");
            Console.ReadLine();

        }
}