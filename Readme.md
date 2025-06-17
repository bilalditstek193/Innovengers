# Folder Structure
Innovengers/
├── src/
│   ├── Innovengers.Domain/           # Domain entities & interfaces
│   ├── Innovengers.Application/      # CQRS, business logic, MediatR handlers
│   ├── Innovengers.Infrastructure/   # EF Core, DbContext, configurations
│   └── Innovengers.UI/               # Blazor Server UI
├── tests/
│   └── Innovengers.Tests/            # Unit tests
├── Innovengers.sln
├── .gitignore
├── README.md




# Commands
# Create solution folder and navigate
mkdir Innovengers
cd Innovengers

# Create the solution file
dotnet new sln -n Innovengers

# Create Class Library projects for core, infrastructure, and services layers
dotnet new classlib -n Innovengers.Core
dotnet new classlib -n Innovengers.Infrastructure
dotnet new classlib -n Innovengers.Services

# Create Blazor Server UI project with minimal API hosting
dotnet new blazor -n Innovengers.UI --interactivity Server

# Add all projects to solution
dotnet sln add Innovengers.Core/Innovengers.Core.csproj
dotnet sln add Innovengers.Infrastructure/Innovengers.Infrastructure.csproj
dotnet sln add Innovengers.Services/Innovengers.Services.csproj
dotnet sln add Innovengers.UI/Innovengers.UI.csproj

# Add project references
dotnet add Innovengers.Infrastructure/Innovengers.Infrastructure.csproj reference Innovengers.Core/Innovengers.Core.csproj
dotnet add Innovengers.Services/Innovengers.Services.csproj reference Innovengers.Core/Innovengers.Core.csproj
dotnet add Innovengers.Services/Innovengers.Services.csproj reference Innovengers.Infrastructure/Innovengers.Infrastructure.csproj
dotnet add Innovengers.UI/Innovengers.UI.csproj reference Innovengers.Services/Innovengers.Services.csproj
dotnet add Innovengers.UI/Innovengers.UI.csproj reference Innovengers.Core/Innovengers.Core.csproj

# Add EF Core and SQL Server packages where needed
dotnet add Innovengers.Infrastructure package Microsoft.EntityFrameworkCore
dotnet add Innovengers.Infrastructure package Microsoft.EntityFrameworkCore.SqlServer

dotnet add Innovengers.UI package Microsoft.EntityFrameworkCore.Design
dotnet add Innovengers.UI package Microsoft.EntityFrameworkCore.SqlServer

# Install Necessary Extensions
adrianwilczynski.blazor-snippet-pack
github.copilot
github.copilot-chat
ms-dotnettools.csdevkit
ms-dotnettools.csharp
ms-dotnettools.vscode-dotnet-runtime
scottsauber.blazorsnippets
syncfusioninc.blazor-vscode-extensions
PS C:\projects\innovengers> code --list-extensions
adrianwilczynski.blazor-snippet-pack
adrianwilczynski.user-secrets
doggy8088.netcore-editorconfiggenerator
esbenp.prettier-vscode
formulahendry.dotnet
formulahendry.dotnet-test-explorer
github.copilot
github.copilot-chat
ionide.ionide-fsharp
ms-dotnettools.csdevkit
ms-dotnettools.csharp
ms-dotnettools.dotnet-interactive-vscode
ms-dotnettools.vscode-dotnet-pack
ms-dotnettools.vscode-dotnet-runtime
ms-dotnettools.vscodeintellicode-csharp
ms-mssql.data-workspace-vscode
ms-mssql.mssql
ms-mssql.sql-bindings-vscode
ms-mssql.sql-database-projects-vscode
ms-toolsai.jupyter
ms-toolsai.jupyter-keymap
ms-toolsai.jupyter-renderers
ms-toolsai.vscode-jupyter-cell-tags
ms-toolsai.vscode-jupyter-slideshow
scottsauber.blazorsnippets
syncfusioninc.blazor-vscode-extensions
