[![](https://img.shields.io/nuget/v/soenneker.datatables.dtos.serversiderequest.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.dtos.serversiderequest/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.dtos.serversiderequest/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.dtos.serversiderequest/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.datatables.dtos.serversiderequest.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.dtos.serversiderequest/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.dtos.serversiderequest/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.dtos.serversiderequest/actions/workflows/codeql.yml)

# Soenneker.DataTables.Dtos.ServerSideRequest

Typed request models for DataTables server-side paging, search, and ordering.

## Installation

```bash
dotnet add package Soenneker.DataTables.Dtos.ServerSideRequest
```

## Bind a JSON request in ASP.NET Core

```csharp
using Microsoft.AspNetCore.Mvc;
using Soenneker.DataTables.Dtos.ServerSideRequest;

[HttpPost("customers/table")]
public IActionResult GetCustomers([FromBody] DataTableServerSideRequest request)
{
    int start = Math.Max(request.Start, 0);
    int length = Math.Clamp(request.Length, 1, 250);

    // Apply validated search/order fields, fetch the page, and return a
    // DataTables server response using request.Draw.
    return Ok();
}
```

A typical JSON body is:

```json
{
  "draw": 3,
  "start": 0,
  "length": 25,
  "search": { "value": "ada", "regex": false },
  "order": [{ "column": 1, "dir": "asc" }],
  "columns": [
    { "data": "id", "name": "id", "searchable": false, "orderable": false, "search": { "value": "", "regex": false } },
    { "data": "name", "name": "name", "searchable": true, "orderable": true, "search": { "value": "", "regex": false } }
  ]
}
```

DataTables commonly submits bracketed form/query keys such as `columns[0][data]` by default. Configure the client to send JSON when using `[FromBody]`, or add an appropriate model binder for the default payload format.

## Validate before querying

- Clamp `Length` to an application-defined maximum and reject unsupported negative values such as DataTables' `-1` “all rows” request.
- Verify every `Order[i].Column` index before indexing `Columns`.
- Map `Columns[i].Data` or `Name` to a known server-side property; never splice the client value into SQL or another query language.
- Accept only `asc` or `desc` for `Dir`.
- Do not enable regular-expression search merely because `Regex` is `true`; regex evaluation can be expensive and unsafe without timeouts and limits.
- Treat `ContinuationToken` as opaque, untrusted input. DataTables does not manage this package-specific extension automatically.

`Search`, `Order`, and `Columns` are nullable because incomplete or custom clients may omit them. Handle that explicitly before applying a query.
