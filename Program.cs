// See https://aka.ms/new-console-template for more information

using System;
using AULA02RH.Models;
using AULA02RH.Models.Enuns;

namespace AULA02RH // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("\n Digite o Id do funcionário: ");
            func.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite o nome do funcionário: ");
            func.Nome = Console.ReadLine();

            Console.WriteLine("\n Digite o CPF do funcionário: ");
            func.Cpf = Console.ReadLine();

            Console.WriteLine("\n Digite a data de admissão do funcionário: ");
            func.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite o salário do funcionário: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite o tipo de funcionário (1 - CLT / 2 - Aprendiz): ");
            int opcao = int.Parse(Console.ReadLine());

            func.TipoFuncionario = (opcao == 1) ? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;
            
            func.ReajustarSalario();
            decimal ValorDescontoVT = func.CalcularDescontoVT(6);
            
            Console.WriteLine("===============================");
            Console.WriteLine($"O salário reajustado do funcionário é {func.Salario}.\n");
            Console.WriteLine($"O desconto do VT é {ValorDescontoVT}");
            Console.WriteLine("===============================");
                        /*
            Funcionario func = new Funcionario();

            func.Id = 10;
            func.Nome = "Neymar";
            func.Cpf = "12345678910";
            func.DataAdmissao = DateTime.Parse("01/01/2000");
            func.Salario = 10000.00M;
            func.TipoFuncionario = TipoFuncionarioEnum.CLT;

            string mensagem = func.ExibirPeriodoExperiencia();
            Console.WriteLine("===============================");
            Console.WriteLine(mensagem);
            Console.WriteLine("===============================");*/


        }


    }
}