public class Curso
{
    public string idcurso { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Carga  { get; set; }
    public int Totaulas { get; set; }
    public int Ano { get; set; }

    public ICollection<GafanhotoAssisteCurso> GafanhotosAssistem { get; set; }
}