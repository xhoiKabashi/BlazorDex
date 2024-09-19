# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the project files
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the code and build the app
COPY . ./
RUN dotnet publish -c Release -o out

# Runtime Stage
FROM nginx:alpine AS runtime
WORKDIR /usr/share/nginx/html

# Copy the published output from the build stage to the Nginx html directory
COPY --from=build /app/out/wwwroot .

COPY nginx.conf /etc/nginx/nginx.conf

# Expose port 80 for the web server
EXPOSE 80

# No need to specify ENTRYPOINT as Nginx runs by default in the base image

