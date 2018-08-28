FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 64184
EXPOSE 44329

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MessageSenderRestApi/MessageSenderRestApi.csproj", "MessageSenderRestApi/"]
RUN dotnet restore "MessageSenderRestApi/MessageSenderRestApi.csproj"
COPY . .
WORKDIR "/src/MessageSenderRestApi"
RUN dotnet build "MessageSenderRestApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MessageSenderRestApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MessageSenderRestApi.dll"]