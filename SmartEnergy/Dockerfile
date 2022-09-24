#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SmartEnergy.csproj", "SmartEnergy/"]
RUN dotnet restore "SmartEnergy/SmartEnergy.csproj"
COPY . .
WORKDIR "/src/SmartEnergy"

RUN dotnet build "SmartEnergy.csproj" -c Release -o out

FROM build AS publish
RUN dotnet publish "SmartEnergy.csproj" -c Release -o /app/publish /p:UseAppHost=true

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SmartEnergy.dll"]
