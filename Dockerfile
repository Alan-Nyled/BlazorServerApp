# Brug en officiel .NET runtime som basebillede
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

# Build-billede
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Kopier .csproj-filer og gendan afhængigheder
COPY ["BlazorServerApp/BlazorServerApp.csproj", "BlazorServerApp/"]
RUN dotnet restore "BlazorServerApp/BlazorServerApp.csproj"

# Kopier resten af koden og byg applikationen
COPY . .
WORKDIR "/src/BlazorServerApp"
RUN dotnet publish -c Release -o /app/publish

# Final-billede
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "BlazorServerApp.dll"]
