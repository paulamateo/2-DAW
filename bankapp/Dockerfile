FROM mcr.microsoft.com/dotnet/sdk:7.0
WORKDIR /bankapp
COPY . .
RUN dotnet publish "bankapp.csproj" -c Release -o /app
ENTRYPOINT [ "dotnet", "bankapp.dll" ]