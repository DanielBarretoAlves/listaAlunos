using System;

class Main
{

    public static void main(string[] args)
    {

        Aluno aluno = new Aluno();

        Console.WriteLine("Digite o nome:");
        aluno.getNomeAluno = Console.ReadLine();

        Console.WriteLine("av1:");
        aluno.getAvaliacao1 = int.Parse(Console.ReadLine());

        Console.WriteLine("av2:");
        aluno.getAvaliacao2 = int.Parse(Console.ReadLine());

        aluno.calculoMedia();


    }


}