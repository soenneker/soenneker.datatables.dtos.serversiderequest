using System.Text.Json.Serialization;

namespace Soenneker.DataTables.Dtos.ServerSideRequest;

/// <summary>
/// Represents a search condition, either global or per-column.
/// </summary>
public sealed class DataTablesSearchRequest
{
    /// <summary>
    /// The search value entered by the user. Can be null or empty.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// Indicates whether the search term should be interpreted as a regular expression.
    /// </summary>
    [JsonPropertyName("regex")]
    public bool Regex { get; set; }
}