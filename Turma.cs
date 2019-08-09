using System;
class Turma
{
	private string nomeTurma;
	private int quantidadeAlunos;
	private float mediaPontos;
	private float pontuacaoTurma;
	private float maiorNota;
	private float menorNota;

	public Turma(string nomeTurma, int quantidadeAlunos, float mediaPontos, float pontuacaoTurma, float maiorNota, float menorNota)
	{
		this.nomeTurma = nomeTurma;
		this.quantidadeAlunos = quantidadeAlunos;
		this.mediaPontos = mediaPontos;
		this.pontuacaoTurma = pontuacaoTurma;
		this.maiorNota = maiorNota;
		this.menorNota = menorNota;
	}
	public Turma() { }

	public string getNomeTurma()
	{
		return nomeTurma;
	}
	public void setNomeTurma(string nomeTurma)
	{
		this.nomeTurma = nomeTurma;
	}
	public int getQuantidadeAlunos()
	{
		return quantidadeAlunos;
	}
	public void setQuantidadeAlunos(int quantidadeAlunos)
	{
		this.quantidadeAlunos = quantidadeAlunos;
	}

	//poderia pegar do JSON esse valor
	public float getPountuacaoTurma()
	{
		return pontuacaoTurma;
	}

	//calc Media
	public float getMediaPontos()
	{
		//Mudar por quantidade de alunos da turma listado no JSON;
		mediaPontos = pontuacaoTurma / 18;
		return mediaPontos;
	}
	public float getMaiorNota()
	{
		return maiorNota;
	}
	public float getMenorNota()
	{
		return menorNota;
	}
}