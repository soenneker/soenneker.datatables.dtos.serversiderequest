using System.Text.Json.Serialization;

namespace Soenneker.DataTables.Dtos.ServerSideRequest;

/// <summary>
/// Represents a single column ordering instruction sent by DataTables.
/// </summary>
public sealed class DataTablesOrderRequest
{
    /// <summary>
    /// The index of the column to apply ordering to (zero-based).
    /// </summary>
    [JsonPropertyName("column")]
    public int Column { get; set; }

    /// <summary>
    /// The direction of the sort: "asc" for ascending, "desc" for descending.
    /// </summary>
    [JsonPropertyName("dir")]
    public string Dir { get; set; } = null!;
}