using system;

class Aluno
{
    private string nomeAluno;
    private string turma;
    private float avaliacao1;
    private float avaliacao2;
    private float mediaAluno;

    public Aluno(string nomeAluno, string turma, float avaliacao1, float avaliacao2, float mediaAluno){
       
       this.nomeAluno = nomeAluno;
       this.turma = turma;
       this.avaliacao1 = avaliacao1;
       this.avaliacao2 = avaliacao2;
       this.mediaAluno = mediaAluno;
    }

    public Aluno(){

    }

    public float calculoMedia(){
        mediaAluno = (avaliacao1 + avaliacao2) / 2;
        return mediaAluno;
    }

    public void setNomeAluno(string nomeAluno){
        this.nomeAluno = nomeAluno;
    }

    public string getNomeAluno(){
        return nomeAluno;
    }

    public void setTurma(string turma){
        this.turma = turma;
    }

    public string getTurma(){
       return turma;
    }

    public void setAvaliacao1(float avaliacao1){
        this.avaliacao1 = avaliacao1;
    }

    public float getAvaliacao1(){
        return avaliacao1;
    }

    public void setAvaliacao2(float avaliacao2){
        this.avaliacao2 = avaliacao2;
    }

    public float getAvaliacao2(){
        return avaliacao2;
    }

    public void setMediaAluno(float mediaAluno){
        this.mediaAluno = mediaAluno;
    }

    public float getMediaAluno(){
        return mediaAluno;
    }
}
 
