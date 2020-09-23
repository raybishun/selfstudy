#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["webapi_basics/webapi_basics.csproj", "webapi_basics/"]
RUN dotnet restore "webapi_basics/webapi_basics.csproj"
COPY . .
WORKDIR "/src/webapi_basics"
RUN dotnet build "webapi_basics.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "webapi_basics.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "webapi_basics.dll"]