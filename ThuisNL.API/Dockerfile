
# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copia solo los csproj primero (para cachear restore)
COPY ThuisNL.API/ThuisNL.API.csproj ThuisNL.API/
COPY ThuisNL.Application/ThuisNL.Application.csproj ThuisNL.Application/
COPY ThuisNL.Core/ThuisNL.Core.csproj ThuisNL.Core/
COPY ThuisNL.Infrastructure/ThuisNL.Infrastructure.csproj ThuisNL.Infrastructure/

# Restore paquetes
RUN dotnet restore ThuisNL.API/ThuisNL.API.csproj

# Copia todo el código
COPY . .

# Build y publish
WORKDIR /src/ThuisNL.API
RUN dotnet publish -c Release -o /app/publish --no-restore

# Etapa 2: Runtime (imagen final super ligera)
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8080
ENTRYPOINT ["dotnet", "ThuisNL.API.dll"]