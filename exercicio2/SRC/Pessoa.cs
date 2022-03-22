namespace exercicio.SRC
{
    public class Pessoa
    {
     public Pessoa(string Nome, string Endereco, int Telefone)
    {
        this.nome = Nome;
        this.endereco=Endereco ;
        this.telefone=Telefone  ;
    }
    private string nome;

    private string endereco ;
    private int telefone;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public string Endereco 
    {
        get { return endereco; }
        set { endereco = value ; }
    }
    public int Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }

        public override string ToString()
        {
            return this.Nome+ "  " + this.Endereco + "  " + this.Telefone  ;

        }
       
}
}