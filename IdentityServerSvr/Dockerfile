FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 64002
EXPOSE 44335

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["IdentityServerSvr/IdentityServerSvr.csproj", "IdentityServerSvr/"]
RUN dotnet restore "IdentityServerSvr/IdentityServerSvr.csproj"
COPY . .
WORKDIR "/src/IdentityServerSvr"
RUN dotnet build "IdentityServerSvr.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "IdentityServerSvr.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "IdentityServerSvr.dll"]