FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

EXPOSE 80
ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Development
ENV LANG=C.UTF-8
ENV LC_ALL=C.UTF-8

WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /CARSITEAPI

COPY ["CARSITE/CARSITEAPI.csproj", "CARSITE/"]
COPY ["BusinessLogic/BusinessLogic.csproj", "BusinessLogic/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["DataAccess/DataAccess.csproj", "DataAccess/"]
RUN dotnet restore "CARSITE/CARSITEAPI.csproj"

COPY . .
FROM build as publish
RUN dotnet publish "CARSITE/CARSITEAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base as final
WORKDIR /app

COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CARSITEAPI.dll"]