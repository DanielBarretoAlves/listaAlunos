using System;

namespace classManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Materia topic = new Materia();
            Turma classroom = new Turma();
            Console.WriteLine(topic.GetAluno("9BM2.json", classroom.selectMateria("9BM2.json")));

        }
    }
}
