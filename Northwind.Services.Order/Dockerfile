FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Northwind.sln ./
COPY Northwind.Services.Order/Northwind.Services.Order.csproj Northwind.Services.Order/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/Northwind.Services.Order
RUN dotnet build -c Debug -o /app

FROM build AS publish
RUN dotnet publish -c Debug -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Northwind.Services.Order.dll"]
