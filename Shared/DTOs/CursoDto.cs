using LP3.BlazorServer.Domain.Enums;

namespace LP3.Shared.DTOs;

/// <summary>DTO para mostrar cursos en listados.</summary>
public class CursoDto
{
    public int    Id       { get; set; }
    public string Nombre   { get; set; } = string.Empty;
    public string Codigo   { get; set; } = string.Empty;
    public string Creditos { get; set; } = string.Empty;
    public string Activo   { get; set; } = string.Empty;
}