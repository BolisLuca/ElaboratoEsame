#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
RUN dotnet restore "DemoHabitTracker/DemoHabitTracker.csproj"
COPY . .
WORKDIR "/src/DemoHabitTracker"
RUN dotnet build "DemoHabitTracker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DemoHabitTracker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoHabitTracker.dll"]