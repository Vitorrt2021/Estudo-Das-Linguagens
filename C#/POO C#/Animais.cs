using System;

namespace POO_C_
{   
    
    public class Animais
    {   
        string[] tiposAnimais = new string[3]{
        "Gato", "Cachorro", "Peixe"};    
        public String nome;
        public int tipo;

        public String Nome{
            get
            {
                return nome;
            }
            set
            {
                this.nome = value.ToUpper();
            }
        }
        public string Tipo{
            get{
                string am;
            /*
                if(this.tipo == 0 || this.tipo ==1 || this.tipo ==2){
                am = tiposAnimais[this.tipo];
                    return am;}
                else{
                    return am = "Peixe";    
                }
            */
            switch(this.tipo)
            {
            case 0:
                am = "Gato";
                
                break;
            case 1:
                am ="Cachorro";
                
                break;
            case 2:
               ;
                am = "Peixes";
                break;
            default:
                am = "Peixe";
                ;
                break;
            }    
                return am;
                
            }
            set{
                this.tipo = Convert.ToInt32(value);
            }
        }
 
        





    }
}