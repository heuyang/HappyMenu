#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["API/HappyMenu.WebApi/HappyMenu.WebApi.csproj", "API/HappyMenu.WebApi/"]
RUN dotnet restore "API/HappyMenu.WebApi/HappyMenu.WebApi.csproj"
COPY . .
WORKDIR "/src/API/HappyMenu.WebApi"
RUN dotnet build "HappyMenu.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HappyMenu.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HappyMenu.WebApi.dll"]