using ClubeDoLivro.Domains;

public class DonoDoLivro
{ 
    public int ID {get; set;}
    public Usuario Usuario { get; set; }
    public Livro Livro { get; set; }    
    public  Versao Versao { get; set; }
}
