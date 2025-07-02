# Gelonezi ExplorerIO SDK

[![GitHub Repo](https://img.shields.io/badge/github-gelonezi%2Fexplorerio--sdk-orange)](https://github.com/stars/gelonezi/lists/explorerio)
[![NuGet Version](https://img.shields.io/nuget/v/Gelonezi.ExplorerIO.Sdk)](https://www.nuget.org/packages/Gelonezi.ExplorerIO.Sdk)

The **Gelonezi ExplorerIO SDK** provides a .NET abstraction layer for integrating with cloud storage services. It handles credentials, service configuration, and exposes a common `IService` interface for read-only operations across multiple providers.

---

## Features (coming soon)

* 🌐 **Multi‑Provider Support**: AWS S3 (initial), plus planned Google Drive, Dropbox, OneDrive, Azure Blob.
* 🔐 **Credential Management**: Centralized `CredentialOptions` and `ICredentialsStore` abstractions.
* 🔌 **Service Abstraction**: `IService` interface with methods for configuration validation, listing folders/items, and generating file URLs.
* 📦 **NuGet‑Ready**: Packaged for easy consumption in your .NET projects.

---

## Prerequisites

* [.NET 9 SDK](https://dotnet.microsoft.com/download)
* [Docker & Docker Compose](https://www.docker.com/) (for sample and integration tests)

---

## Installation

Install the SDK from NuGet:

```bash
dotnet add package Gelonezi.ExplorerIO.Sdk
```

---

## Development Setup

1. **Start Dependencies** (integration tests, samples):

   ```bash
   docker compose -f docker-compose/develop.yaml up -d
   ```

2. **Build & Run Tests**:

   ```bash
   dotnet build
   dotnet test
   ```

3. **Run Sample Console App**:

   ```bash
   dotnet run --project ./samples/Gelonezi.Console.Sdk
   ```

---

## Project Structure

```text
/src
  └─ Gelonezi.ExplorerIO.Sdk        # SDK implementation
/tests
  ├─ unit                           # Unit tests (no external dependencies)
  └─ integration                    # Integration tests (uses Docker Compose)
/samples
  └─ Gelonezi.Console.Sdk           # Sample usage console app
```

---

## Usage Example

```csharp
using Gelonezi.ExplorerIo.Sdk.Abstractions.Interfaces.Service.V1;
using Gelonezi.ExplorerIo.Sdk.Abstractions.Models.Service.V1;

// Resolve via DI or manual instantiation
iService = new S3ExplorerService(options, logger);

var result = await iService.IsConfigurationValidAsync("default");
if (!result.IsSuccess) throw new Exception(result.Message);

var buckets = await iService.ListRootFoldersAsync("default");
Console.WriteLine("Buckets:");
buckets.Value.ToList().ForEach(b => Console.WriteLine(b.FolderName));
```

---

## Documentation & Contributions

Full documentation at [exploreriodocs.gelonezi.com](https://exploreriodocs.gelonezi.com).

Guidelines for Contributions is available in the full documentation.

---

*This README will evolve as the SDK grows, adding more samples, detailed guides, and advanced scenarios.*
