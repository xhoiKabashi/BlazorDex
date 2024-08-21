FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app

COPY . .
EXPOSE 80

RUN dotnet publish -c Release -o out

ENTRYPOINT ["dotnet", "BlazorDex.dll"]