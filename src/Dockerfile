FROM microsoft/dotnet:2.0.3-sdk-nanoserver-1709 AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# build runtime image
FROM microsoft/dotnet:2.0.3-runtime-nanoserver-1709
WORKDIR /app
COPY --from=build-env /app/out ./
ENTRYPOINT [ "dotnet", "timewaster.dll" ]

