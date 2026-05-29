using System.Text.Json.Serialization;

namespace proyectoEstetica3raParcial.Models;

public class ServicioSalud
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nombre")]
    public string Nombre { get; set; } = string.Empty;

    [JsonPropertyName("descripcion")]
    public string? Descripcion { get; set; }

    [JsonPropertyName("precio")]
    public decimal Precio { get; set; }

    [JsonPropertyName("duracion")]
    public int Duracion { get; set; }

    [JsonPropertyName("requiereCita")]
    public bool RequiereCita { get; set; }

    [JsonPropertyName("especialidad")]
    public string? Especialidad { get; set; }

    [JsonPropertyName("especialidadId")]
    public int EspecialidadId { get; set; }
}