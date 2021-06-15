using System;

namespace POO_C_
{
    class Program
    {
    
        static void Main(string[] args)
        {

            int cachorros = 0, gatos = 0 , peixes = 0;
            Animais a = new Animais();
            for(int i=0;i < 2;i++){
            Console.WriteLine("Nome do animal:  ");
            a.Nome = Console.ReadLine();
            Console.WriteLine(" Tipo 0: Gato \n Tipo 1: Cachorro \n Tipo 2: Peixe");
            a.Tipo = Console.ReadLine();
            switch(Convert.ToInt32(a.tipo))
            {
                case 0:
                gatos+=1;
                break;
                case 1:
                cachorros+=1;
                break;
                case 2:
                peixes +=1;
                break;
                default:
                peixes +=1;
                break;
            }
            }
            Console.WriteLine("Numero de Gatos: " + gatos);
            Console.WriteLine("Numero de Cachorros:  " + cachorros);
            Console.WriteLine("Numero de Peixe:  " + peixes);


            Console.WriteLine("Calculadora de idade \n");
            Humano p = new Humano();
            Console.Write("Nome da Pessoa: ");
            p.Nome = Console.ReadLine();
            Console.Write("Ano de Nascimento: ");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());
            p.ExibirDados();
            
            
            
            Mensagem msg2;
            msg2 = new Mensagem();
            msg2.TextoMensagem = "O certo a se fazer com c#";
            msg2.ExibirMensagem();


    
    /*
            Mensagem msg1;
            msg1 = new Mensagem();
            msg1.setTextoMensagem("Setando o valor de texto mensagem \n") ;
            Console.Write(msg1.getTextoMensagem());
            msg1.ExibirMensagem();
        }
    */



    }
    }
}
