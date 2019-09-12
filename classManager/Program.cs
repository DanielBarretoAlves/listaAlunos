using System;

namespace classManager
{
    class Program
    {
        static void Main(string[] args)
        {
            bool key = false;
            string addKey;

            while (key != true)
            {
                Materia materia = new Materia();
                Turma classroom = new Turma();
                Alunos student = new Alunos();
                //Aluno aluno1 = new Aluno();
                string turma = classroom.GetTurma();
                int sala = materia.selectMateria(turma);
                string nome = materia.GetAluno(turma, sala);
                Console.WriteLine("Rendimento: " + student.getRendimento(turma, sala, nome) + "%");
                Console.WriteLine("Media da Materia: " + materia.getMediaSala(turma, sala));
                materia.showNotaVermelha(turma, sala);
                Console.WriteLine("Digite SAIR para Sair");
                addKey = Console.ReadLine();
                if (addKey == "sair")
                {
                    key = true;
                }
            }
            

            
            
            
        }
    }
}
