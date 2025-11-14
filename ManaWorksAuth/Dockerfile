# Build da API
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out

# Imagem final para rodar
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Porta padrão do container (pode ser qualquer uma, aqui 80)
EXPOSE 5214

ENTRYPOINT ["dotnet", "ManaWorksAuth.dll"]