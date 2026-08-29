[![](https://img.shields.io/nuget/v/soenneker.datatables.dtos.serversiderequest.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.dtos.serversiderequest/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.dtos.serversiderequest/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.dtos.serversiderequest/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.datatables.dtos.serversiderequest.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.dtos.serversiderequest/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.dtos.serversiderequest/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.dtos.serversiderequest/actions/workflows/codeql.yml)

# Soenneker.DataTables.Dtos.ServerSideRequest

Represents the data table column request.

## Install

```bash
dotnet add package Soenneker.DataTables.Dtos.ServerSideRequest
```

## What you get

- `DataTableColumnRequest` — Represents the data table column request.
- `DataTableOrderRequest` — Represents a single column ordering instruction sent by DataTables.
- `DataTableSearchRequest` — Represents a search condition, either global or per-column.
- `DataTableServerSideRequest` — Represents a server-side processing request from DataTables.js.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `DataTableColumnRequest.Data` | The property name or field bound to the column's data in the source. | The property name or field bound to the column's data in the source. |
| `DataTableColumnRequest.Name` | Optional column name used for more advanced setups. Often blank. | Optional column name used for more advanced setups. Often blank. |
| `DataTableColumnRequest.Searchable` | Indicates whether the column is searchable. | Indicates whether the column is searchable. |
| `DataTableColumnRequest.Orderable` | Indicates whether the column is orderable (sortable). | Indicates whether the column is orderable (sortable). |
| `DataTableColumnRequest.Search` | Column-specific search term and options. Can be null if no per-column search is applied. | Column-specific search term and options. Can be null if no per-column search is applied. |
| `DataTableOrderRequest.Column` | The index of the column to apply ordering to (zero-based). | The index of the column to apply ordering to (zero-based). |
| `DataTableOrderRequest.Dir` | The direction of the sort: "asc" for ascending, "desc" for descending. | The direction of the sort: "asc" for ascending, "desc" for descending. |
| `DataTableSearchRequest.Value` | The search value entered by the user. Can be null or empty. | The search value entered by the user. Can be null or empty. |
| `DataTableSearchRequest.Regex` | Indicates whether the search term should be interpreted as a regular expression. | Indicates whether the search term should be interpreted as a regular expression. |
| `DataTableServerSideRequest.Draw` | Draw counter sent by DataTables to ensure request/response alignment. This should be echoed back in the response. | Draw counter sent by DataTables to ensure request/response alignment. This should be echoed back in the response. |
| `DataTableServerSideRequest.Start` | The zero-based index of the first record to return (for pagination). | The zero-based index of the first record to return (for pagination). |
| `DataTableServerSideRequest.Length` | The number of records to return (page size). | The number of records to return (page size). |
| `DataTableServerSideRequest.ContinuationToken` | If applicable, a storage continuation token that the client must send back on the next request. This is the client's next page token for retrieving more data. Set to null on first paged request. Optional. | If applicable, a storage continuation token that the client must send back on the next request. This is the client's next page token for retrieving more data. Set to null on first paged request. Optional. |
| `DataTableServerSideRequest.Search` | Global search term and options. Can be null if no global search is applied. | Global search term and options. Can be null if no global search is applied. |
| `DataTableServerSideRequest.Order` | Sorting instructions sent by DataTables, ordered by priority. Can be null if no ordering is applied. | Sorting instructions sent by DataTables, ordered by priority. Can be null if no ordering is applied. |
| `DataTableServerSideRequest.Columns` | Metadata for each column in the table, including search and sort options. May be null but typically present. | Metadata for each column in the table, including search and sort options. May be null but typically present. |
