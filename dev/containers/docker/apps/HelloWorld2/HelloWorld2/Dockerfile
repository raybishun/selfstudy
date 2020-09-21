#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["HelloWorld2/HelloWorld2.csproj", "HelloWorld2/"]
RUN dotnet restore "HelloWorld2/HelloWorld2.csproj"
COPY . .
WORKDIR "/src/HelloWorld2"
RUN dotnet build "HelloWorld2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HelloWorld2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HelloWorld2.dll"]