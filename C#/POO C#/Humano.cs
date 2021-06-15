using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_C_
{
    public class Humano
    {
        public String nome;
        public String Nome
        {
            get 
            {
                return nome;
            }
            set
            {
                this.nome = value.ToUpper() ;
            }   
        }
        public int anoNascimento;
        public int AnoNascimento
        {
            get 
            {
                return anoNascimento;
            }
            set{
                this.anoNascimento = value;
            }
        }
        public int CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            int idade = ano - this.AnoNascimento;
            return idade;
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Nascimento: " + this.anoNascimento);
            int idade = this.CalcularIdade();
            Console.WriteLine("Idade: " + idade);
        }


    }
}