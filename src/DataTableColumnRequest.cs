using System.Text.Json.Serialization;

namespace Soenneker.DataTables.Dtos.ServerSideRequest;

public sealed class DataTableColumnRequest
{
    /// <summary>
    /// The property name or field bound to the column's data in the source.
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>
    /// Optional column name used for more advanced setups. Often blank.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Indicates whether the column is searchable.
    /// </summary>
    [JsonPropertyName("searchable")]
    public bool Searchable { get; set; }

    /// <summary>
    /// Indicates whether the column is orderable (sortable).
    /// </summary>
    [JsonPropertyName("orderable")]
    public bool Orderable { get; set; }

    /// <summary>
    /// Column-specific search term and options. Can be null if no per-column search is applied.
    /// </summary>
    [JsonPropertyName("search")]
    public DataTableSearchRequest? Search { get; set; }
}