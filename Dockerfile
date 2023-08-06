FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app


# copy csproj and restore as distinct layers
COPY apiRest/apiRest.sln .
COPY apiRest/apiRest/apiRest.csproj ./apiRest/
RUN dotnet restore

# copy everything else and build app
COPY apiRest/apiRest/. ./apiRest/
WORKDIR /app/apiRest
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=build /app/apiRest/out ./
EXPOSE 80
ENTRYPOINT ["dotnet", "apiRest.dll"]