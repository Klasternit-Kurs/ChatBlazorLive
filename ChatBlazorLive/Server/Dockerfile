#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ChatBlazorLive/Server/ChatBlazorLive.Server.csproj", "ChatBlazorLive/Server/"]
COPY ["ChatBlazorLive/Client/ChatBlazorLive.Client.csproj", "ChatBlazorLive/Client/"]
COPY ["ChatBlazorLive/Shared/ChatBlazorLive.Shared.csproj", "ChatBlazorLive/Shared/"]
RUN dotnet restore "ChatBlazorLive/Server/ChatBlazorLive.Server.csproj"
COPY . .
WORKDIR "/src/ChatBlazorLive/Server"
RUN dotnet build "ChatBlazorLive.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ChatBlazorLive.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ChatBlazorLive.Server.dll"]