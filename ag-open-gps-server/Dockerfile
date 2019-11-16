FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app

ARG NPM_TOKEN

RUN curl -sL https://deb.nodesource.com/setup_10.x |  bash -
RUN apt-get install -y nodejs

COPY . ./

RUN dotnet restore 

RUN dotnet build ./ag-open-gps-server.sln

RUN dotnet publish ./ag-open-gps-web/ag-open-gps-web.csproj -c Release -o out

FROM microsoft/dotnet:aspnetcore-runtime
EXPOSE 80
WORKDIR /app
COPY --from=build-env /app/ag-open-gps-web/out ./

ENTRYPOINT ["dotnet", "ag-open-gps-web.dll"]