FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# Copy everything
COPY *.csproj ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image 

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /appdou
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "CommandsService.dll"]
#docker build -t mariayarema/commandservice .
#docker push  mariayarema/commandservice 

#docker run -p 8080:80 -d mariayarema/platformservice
# docker run -p 8080:80 mariayarema/commandservice          
#docker ps
# docker stop ....Id...