using System;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Luciano", "T4");
            Console.WriteLine(a1);
            Aluno a2 = new Aluno("Adriano", "T3");
            Console.WriteLine(a2);
            Console.WriteLine(Repositorio.BancoDeDados);            

            Repositorio.AdicionaAluno(a1);
            Repositorio.AdicionaAluno(a2);

            int i = 0;

            while(i < 10)
            {
                Console.WriteLine("Informe qual aluno quer pesquisar");
                int opcao = int.Parse(Console.ReadLine());
                Aluno aluno = Repositorio.BuscaALuno(opcao);
                Console.WriteLine(aluno);
                i++;
            }
        }
    }
}
