using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClickToStudy
{
    internal class PessoaWorker:Pessoa
    {
        string form;
        //public string getForm()
        //{
        //    return form;
        //}

        public void setForm(string form)
        {
            this.form = form;
        }
        public void SalvarPessoaCSV()
        {
            var linha = form;

            using (StreamWriter arquivo = new StreamWriter(@"C:\Users\rafae\Desktop\SalvarPessoaCSV\pessoa.csv", true))
                arquivo.WriteLine(linha);
        }
    }
}
