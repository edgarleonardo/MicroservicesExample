FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 63647
EXPOSE 44362

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MicroservicesExample/MicroservicesExample.csproj", "MicroservicesExample/"]
RUN dotnet restore "MicroservicesExample/MicroservicesExample.csproj"
COPY . .
WORKDIR "/src/MicroservicesExample"
RUN dotnet build "MicroservicesExample.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MicroservicesExample.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroservicesExample.dll"]