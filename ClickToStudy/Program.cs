using System;
using System.Reflection.PortableExecutable;
using ClickToStudy;
using static ClickToStudy.Pessoa;


namespace PessoaEmExcel
{
    class PessoaEmExcel
    {
        static void Main(string[] args)
        {

            string nome;
            int idade;
            string cpf;
            DateOnly dtnascimento;
            char sexo;
            string celular;

           Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("Digite seu nome: ");
            nome= Console.ReadLine();
            pessoa1.setNome(nome);

            Console.WriteLine("Digite sua idade: ");
            idade= int.Parse(Console.ReadLine());
            pessoa1.setIdade(idade);

            Console.WriteLine("Digite seu CPF sem pontos: ");
            cpf= Console.ReadLine();
            pessoa1.setCPF(cpf);

            Console.WriteLine("Digite sua Data de Nascimento: ");
            dtnascimento = DateOnly.Parse((Console.ReadLine()));
            pessoa1.setDtNascimento(dtnascimento);

            Console.WriteLine("Digite seu sexo: ");
            sexo = Convert.ToChar(Console.ReadLine());
            pessoa1.setSexo(sexo);

            Console.WriteLine("Digite o seu celular: ");
            celular = Console.ReadLine();
            pessoa1.setCelular(celular);


            Console.WriteLine(pessoa1.getNome()+ "," + pessoa1.getIdade() + "," + pessoa1.getCPF() + "," + pessoa1.getDtNascimento() + "," + pessoa1.getSexo() + "," + pessoa1.getCelular());

            String p;
            PessoaWorker form = new PessoaWorker();
            p = nome + ";" + idade + ";" + cpf + ";" + dtnascimento + ";" + sexo + ";" + celular;
            form.setForm(p);

            form.SalvarPessoaCSV();
        }

    }


}