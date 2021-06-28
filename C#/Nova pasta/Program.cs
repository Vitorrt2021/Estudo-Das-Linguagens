using System;

namespace Nova_pasta
{
    class Program
    {
        static string Escolher(){
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1. Inserir novo aluno: ");
            Console.WriteLine("2. listar alunos: ");
            Console.WriteLine("3. Calcular média geral: ");
            Console.WriteLine("x - Sair");
            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
        static void Main(string[] args)
        {   
            int indiceAluno = 0;
            Aluno[] alunos = new Aluno[5];
            string opcaoUsuario = Escolher();
            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:  ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
            
                        Console.WriteLine("Informe a nota do aluno");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else{
                            throw new ArgumentException("O valor da nota deve ser decimal: ");
                        }
                        alunos[indiceAluno] = aluno;
                        indiceAluno +=1;
                        break;        
                    case "2":
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                            Console.WriteLine("ALUNO: " + a.Nome + " NOTA: " + a.Nota );
                            }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for (int i=0; i <alunos.Length;i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos ++;
                            }

                        }
                        string nocao;
                        var mediaGeral = notaTotal/nrAlunos;
                        if (mediaGeral < 4){
                            nocao = "D";
                        }
                        else if (mediaGeral < 6){
                            nocao = "C";
                        }
                        else if (mediaGeral < 8){
                            nocao = "B";
                        }
                        else {
                            nocao = "A";
                        }
                        
                        Console.WriteLine("Media Geral: " + mediaGeral + " Conceito Da Classe: " + nocao);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                    opcaoUsuario = Escolher();
            
        }
       
    }
}
}
