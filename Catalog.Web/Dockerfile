FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Catalog.Web/Catalog.Web.csproj", "Catalog.Web/"]
RUN dotnet restore "Catalog.Web/Catalog.Web.csproj"
COPY . .
WORKDIR "/src/Catalog.Web"
RUN dotnet build "Catalog.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Catalog.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Catalog.Web.dll"]
