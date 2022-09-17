using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ClickToStudy
{
    public class Pessoa
    {
        private string Nome;
        private int Idade;
        private string CPF;
        private DateOnly DtNascimento;
        private char Sexo;
        private string Celular;


        public string getNome() {
            return Nome;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }


        
        public int getIdade() {
            return Idade;
        }

        public void setIdade (int idade)
        {
            this.Idade = idade;
        }
       

        public string getCPF()
        {
            return CPF;
        }

        public void setCPF(string cpf)
        {
            this.CPF = cpf;
        }
      

        public DateOnly getDtNascimento()
        {
            return DtNascimento;
        }

        public void setDtNascimento(DateOnly dtnascimento)
        {
            this.DtNascimento = dtnascimento;
        }

        public char getSexo()
        {
            return Sexo;
        }

        public void setSexo(char sexo)
        {
            this.Sexo = sexo;
        }

        public string getCelular()
        {
            return Celular;
        }

        public void setCelular(string celular)
        {
            this.Celular = celular;
        }
            
    }
}
