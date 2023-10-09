FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DelegateBasicExample.csproj", "./"]
RUN dotnet restore "DelegateBasicExample.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "DelegateBasicExample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DelegateBasicExample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DelegateBasicExample.dll"]
