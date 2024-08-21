FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app

COPY . .
EXPOSE 80

RUN dotnet publish -c Release -o out

ENTRYPOINT ["dotnet", "MyBlazorApp.dll"]  # Replace with your app's assembly name