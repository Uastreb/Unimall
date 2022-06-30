#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Unimall_TelegramBot/Unimall_TelegramBot.csproj", "Unimall_TelegramBot/"]
RUN dotnet restore "Unimall_TelegramBot/Unimall_TelegramBot.csproj"
COPY . .
WORKDIR "/src/Unimall_TelegramBot"
RUN dotnet build "Unimall_TelegramBot.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Unimall_TelegramBot.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Unimall_TelegramBot.dll"]