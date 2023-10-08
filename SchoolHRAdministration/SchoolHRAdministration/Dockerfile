FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SchoolHRAdministration/SchoolHRAdministration.csproj", "SchoolHRAdministration/"]
RUN dotnet restore "SchoolHRAdministration/SchoolHRAdministration.csproj"
COPY . .
WORKDIR "/src/SchoolHRAdministration"
RUN dotnet build "SchoolHRAdministration.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SchoolHRAdministration.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SchoolHRAdministration.dll"]
