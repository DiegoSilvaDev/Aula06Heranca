using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();
            CNPJ cnpj = new CNPJ();
            cpf.nome = "Paulo";
            Console.WriteLine(cpf.Saudar());

            cpf.cpf = "000.000.000-00";
            Console.WriteLine(cpf.ValidarCPF());

            cnpj.cnpj = "000.000.000/0000-00";
            Console.WriteLine(cnpj.ValidarCNPJ());
        }
    }
}
