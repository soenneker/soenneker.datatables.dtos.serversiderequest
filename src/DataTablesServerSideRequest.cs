using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.DataTables.Dtos.ServerSideRequest;

/// <summary>
/// Represents a server-side processing request from DataTables.js.
/// </summary>
public sealed class DataTablesServerSideRequest
{
    /// <summary>
    /// Draw counter sent by DataTables to ensure request/response alignment. This should be echoed back in the response.
    /// </summary>
    [JsonPropertyName("draw")]
    public int Draw { get; set; }

    /// <summary>
    /// The zero-based index of the first record to return (for pagination).
    /// </summary>
    [JsonPropertyName("start")]
    public int Start { get; set; }

    /// <summary>
    /// The number of records to return (page size).
    /// </summary>
    [JsonPropertyName("length")]
    public int Length { get; set; }

    /// <summary>
    /// Global search term and options. Can be null if no global search is applied.
    /// </summary>
    [JsonPropertyName("search")]
    public DataTablesSearchRequest? Search { get; set; }

    /// <summary>
    /// Sorting instructions sent by DataTables, ordered by priority. Can be null if no ordering is applied.
    /// </summary>
    [JsonPropertyName("order")]
    public List<DataTablesOrderRequest>? Order { get; set; }

    /// <summary>
    /// Metadata for each column in the table, including search and sort options. May be null but typically present.
    /// </summary>
    [JsonPropertyName("columns")]
    public List<DataTablesColumnRequest>? Columns { get; set; }
}
