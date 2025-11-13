FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ManaWorksVacancy/ManaWorksVacancy.csproj", "ManaWorksVacancy/"]
RUN dotnet restore "ManaWorksVacancy/ManaWorksVacancy.csproj"
COPY . .
WORKDIR "/src/ManaWorksVacancy"
RUN dotnet build "./ManaWorksVacancy.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ManaWorksVacancy.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ManaWorksVacancy.dll"]
