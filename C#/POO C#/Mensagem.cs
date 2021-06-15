using System;

namespace POO_C_
{
    public class Mensagem
    {
    
    /*
        // Caracteristica textoMensagem
        private String TextoMensagem; 

        public void ExibirMensagem(){
            Console.WriteLine(this.TextoMensagem);
        }
        //Seta um metodo para acessar o atributo textomensagem
        public String getTextoMensagem()
        {
            return this.TextoMensagem;
        }
        public void setTextoMensagem(String valor)
        {
            this.TextoMensagem = valor;
        }
    */
        private String textoMensagem;
        public String TextoMensagem
        {
            get
            {
                return this.textoMensagem;
            }
            set
            {
                this.textoMensagem = value ;
            }
        }
        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }


    }
}