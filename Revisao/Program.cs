using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: Adicionar alunos
                        Console.WriteLine("Informe o nome do Aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do Aluno:");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.Nota = nota;
                        } else{
                            throw new ArgumentException("Valor da nota deve ser decima.");
                        }
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        
                        break;
                    case "2":
                        //TODO: listar alunos
                        foreach(var eachAluno in alunos){
                            if(!string.IsNullOrEmpty(eachAluno.Nome)){
                                Console.WriteLine($"Aluno: {eachAluno.Nome}. Nota: {eachAluno.Nota}");
                            }
                        }
                        break;
                    case "3":
                        //TODO: Calcular média alunos
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for(int i = 0; i < alunos.Length; i++){
                            if(!string.IsNullOrEmpty(alunos[i].Nome)){
                                notaTotal += alunos[i].Nota;
                                nrAlunos++;
                            }
                        }
                        var mediaGeral = notaTotal/nrAlunos;
                        Conceito conceitoGeral;

                        if(mediaGeral <2){
                            conceitoGeral = Conceito.E;
                        } else if(mediaGeral < 4){
                            conceitoGeral = Conceito.D;
                        } else if(mediaGeral < 6){
                            conceitoGeral = Conceito.C;
                        } else if(mediaGeral < 8){
                            conceitoGeral = Conceito.B;
                        } else {
                            conceitoGeral = Conceito.A;
                        } 
                        
                        Console.WriteLine($"Média Geral = {mediaGeral} --- Conceito: {conceitoGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

            
                opcaoUsuario = ObterOpcaoUsuario();
                
            }


        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            String opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
