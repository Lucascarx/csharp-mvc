public class Gafanhoto
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public ICollection<GafanhotoAssisteCurso> CursosAssistidos { get; set; }
}
