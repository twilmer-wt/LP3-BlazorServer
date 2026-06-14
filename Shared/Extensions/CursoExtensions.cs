namespace LP3.BlazorServer.Shared.Extensions;
using LP3.BlazorServer.Domain.Entities;
using LP3.Shared.DTOs;

/// <summary>
/// Métodos de conversión entre Entidad y DTO.
/// </summary>
public static class CursoExtensions
{
    public static CursoDto ToDto(this Curso e)
        => new()
        {
            Id        = e.Id,
            Nombre    = e.Nombre,
            Codigo    = e.Codigo,
            Creditos  = e.Creditos.ToString(),
            Activo    = e.Activo.ToString()
        };

    public static Curso ToEntity(this CursoFormDto dto)
        => new()
        {
            Nombre    = dto.Nombre,
            Codigo    = dto.Codigo,
            Creditos  = int.Parse(dto.Creditos),
            Activo    = dto.Activo
        };
}