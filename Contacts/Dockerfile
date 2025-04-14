FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Fuhrpark - Prog 2 Lab/Fuhrpark - Prog 2 Lab.csproj", "Fuhrpark - Prog 2 Lab/"]
RUN dotnet restore "Fuhrpark - Prog 2 Lab/Fuhrpark - Prog 2 Lab.csproj"
COPY . .
WORKDIR "/src/Fuhrpark - Prog 2 Lab"
RUN dotnet build "Fuhrpark - Prog 2 Lab.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Fuhrpark - Prog 2 Lab.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fuhrpark - Prog 2 Lab.dll"]
