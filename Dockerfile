
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["BE_SWP391.sln", "./"]
COPY ["SWP391.Api/SWP391.Api.csproj", "SWP391.Api/"]
COPY ["SWP391.Application/SWP391.Application.csproj", "SWP391.Application/"]
COPY ["SWP391.Infrastructure/SWP391.Infrastructure.csproj", "SWP391.Infrastructure/"]
RUN dotnet restore "SWP391.sln"

COPY . .
WORKDIR "/src"
RUN dotnet build "BE_SWP391.sln" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BE_SWP391.sln" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SWP391.Api.dll"]