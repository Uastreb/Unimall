#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Unimall_Worker/Unimall_Worker.csproj", "Unimall_Worker/"]
RUN dotnet restore "Unimall_Worker/Unimall_Worker.csproj"
COPY . .
WORKDIR "/src/Unimall_Worker"
RUN dotnet build "Unimall_Worker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Unimall_Worker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Unimall_Worker.dll"]