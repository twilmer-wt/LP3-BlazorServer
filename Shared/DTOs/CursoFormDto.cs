namespace LP3.Shared.DTOs;

public class CursoFormDto
{
    public int?   Id        { get; set; }  // null = crear nuevo
    public string Nombre    { get; set; } = string.Empty;
    public string Codigo    { get; set; } = string.Empty;
    public string Creditos  { get; set; } = string.Empty;
    public bool   Activo    { get; set; } = true;
}
