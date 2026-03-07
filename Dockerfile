FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 5010
ENV ASPNETCORE_URLS=http://+:5010

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["LuxeStep.csproj", "."]
RUN dotnet restore "./LuxeStep.csproj"
COPY . .
RUN dotnet build "LuxeStep.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LuxeStep.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LuxeStep.dll"]
