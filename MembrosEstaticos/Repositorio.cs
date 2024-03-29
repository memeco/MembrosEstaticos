namespace MembrosEstaticos
{
    public static class Repositorio
    {
        public static string BancoDeDados = "SQL SERVER";
        private static int _index = 0;
        private static Aluno[] _alunos = new Aluno[100];

        public static void AdicionaAluno(Aluno aluno)
        {
            _alunos[_index] = aluno;
            _index++;
        }

        public static Aluno BuscaALuno(int indice)
        {
            return _alunos[indice];
        }
    }
}