FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["design_patterns_dummies/design_patterns_dummies.csproj", "design_patterns_dummies/"]
RUN dotnet restore "design_patterns_dummies/design_patterns_dummies.csproj"
COPY . .
WORKDIR "/src/design_patterns_dummies"
RUN dotnet build "design_patterns_dummies.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "design_patterns_dummies.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "design_patterns_dummies.dll"]
