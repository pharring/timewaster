#
# For a Windows Nanoserver container use --build-arg on the docker build command line.
# e.g. For Windows Nanoserver 2016 Version 1709 (Fall Creators Update)
#   docker build --build-arg NANOSERVER=-nanoserver-1709 -t timewaster:1709 .
# e.g. For Windows Nanoserver 2016 Semi Annual Channel
#   docker build --build-arg NANOSERVER=-nanoserver-sac2016 -t timewaster:sac2016 .
#

ARG NANOSERVER
FROM microsoft/dotnet:2.0.3-sdk${NANOSERVER} AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# build runtime image
FROM microsoft/dotnet:2.0.3-runtime${NANOSERVER}
WORKDIR /app
COPY --from=build-env /app/out ./
ENTRYPOINT [ "dotnet", "Timewaster.dll" ]

