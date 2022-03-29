#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MajoSiriusApi.csproj", "./"]
RUN dotnet restore "MajoSiriusApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "MajoSiriusApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MajoSiriusApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MajoSiriusApi.dll"]