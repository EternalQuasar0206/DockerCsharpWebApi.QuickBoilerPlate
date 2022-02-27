FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DockerCsharpWebApi.QuickBoilerPlate/DockerCsharpWebApi.QuickBoilerPlate.csproj", "DockerCsharpWebApi.QuickBoilerPlate/"]
RUN dotnet restore "DockerCsharpWebApi.QuickBoilerPlate/DockerCsharpWebApi.QuickBoilerPlate.csproj"
COPY . .
WORKDIR "/src/DockerCsharpWebApi.QuickBoilerPlate"
RUN dotnet build "DockerCsharpWebApi.QuickBoilerPlate.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerCsharpWebApi.QuickBoilerPlate.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerCsharpWebApi.QuickBoilerPlate.dll"]