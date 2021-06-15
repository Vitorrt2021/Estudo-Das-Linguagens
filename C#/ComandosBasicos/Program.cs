using System;

namespace C_
{
    class Program
    {
        enum Cor {Azul, Verde, Amarelo, Vermelho}
        static void Main(string[] args)
        {
        /*
            variavel dynamic tem a tipagem dinamica que pode mudar.
            dynamic Dinamico = "mais";
            int Inteiro = 23;
            string Frase = "Muitas letras";
            bool Boleana = true;
            float Real = 3.23f;
            double RealMaior = 3.1234f;

            const float PI = 3.14f;
            
            var meuTexto = "Hello World!";
            Console.WriteLine(meuTexto);
            
            string nome;
            Console.WriteLine("Escreva seu nome:  ");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome ");
            Console.WriteLine(nome);
        
            if (2 < 34){
                Console.WriteLine("2 é menor que 34");
            }
            else if(2 == 34){
                Console.WriteLine("2 é igual a 34");
            }
            else{
                Console.WriteLine("2 não é menor que 34");
            }
        
        && é igual ao OU
        || é igual ao E

        if (9 < 2 || 9 == 2){
            Console.WriteLine("9 é menor ou igual a 2");
        }
        else{
            Console.WriteLine("9 e maior que 2");
        }
    
        //Pega uma string que o usuario digitou e o tranforma em um inteiro.
        int idade1 = int.Parse(Console.ReadLine());
        
        ExibirMsg();
        Console.WriteLine(GerarPreco(100,23));

        string[] produtos = new string[5] 
        {
            "0",
            "1",
            "2",
            "3",
            "4"
        };
    
        Console.WriteLine("Numero no index 2 do array produtos que não tem produtos: "+produtos[2]);
        

        string cor = "Azul";
        switch(cor){

            case "Azul":
                Console.WriteLine("A cor é Azul" );
                break;
            case "Vermelho":
                Console.WriteLine("A cor é vermelho");
                break;
            case "Branco":
                Console.WriteLine("A cor é Branco");
                break;
            default:
                Console.WriteLine("Não sei a cor");
                break;
    */
            
            Cor corFavorita = Cor.Verde;
            Console.WriteLine(corFavorita);
            int contador = 0;
            while (contador < 5){
                Console.WriteLine(contador);
                contador += 1;
            }
            do{
                Console.WriteLine(contador);
                contador +=1;
            }while(contador < 10);

            string[] palavras = new string[4] {
                "Um",
                "Dois",
                "Três",
                "Quatro"
            };
            foreach(string palavra in palavras){
                Console.WriteLine(palavra);
            }
            for(int contador1 = 0;contador1 < contador;contador1 ++){
                Console.WriteLine(contador1);
            }

            


        }
    }
        
    

    /*
    static float GerarPreco(float preco, float desconto)
    {
        preco = preco - (preco * (desconto/100));
        return preco;

    }

    static void ExibirMsg(){
        
        Console.WriteLine("Execução da função ExibirMsg");


        }
    */    

   }

