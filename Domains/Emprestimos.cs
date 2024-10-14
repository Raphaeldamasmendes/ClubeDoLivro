using ClubeDoLivro.Domains;

public class Emprestimos
{
    public int ID { get; set; }
    public Livro Livro { get; set; }
    public Livro Dono { get; set; }
    public Usuario Solicitante { get; set; }
    public DateTime DtaEmrpestimo { get; set; }
    public DateTime DataDevolucao { get; set; }
}
