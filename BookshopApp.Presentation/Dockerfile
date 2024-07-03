# Dockerfile for BookshopApp.Presentation
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BookshopApp.Presentation/BookshopApp.Presentation.csproj", "BookshopApp.Presentation/"]
COPY ["BookshopApp.Application/BookshopApp.Application.csproj", "BookshopApp.Application/"]
COPY ["BookshopApp.Core/BookshopApp.Core.csproj", "BookshopApp.Core/"]
COPY ["BookshopApp.Infrastructure/BookshopApp.Infrastructure.csproj", "BookshopApp.Infrastructure/"]
RUN dotnet restore "BookshopApp.Presentation/BookshopApp.Presentation.csproj"
COPY . .
WORKDIR "/src/BookshopApp.Presentation"
RUN dotnet build "BookshopApp.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BookshopApp.Presentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BookshopApp.Presentation.dll"]
 