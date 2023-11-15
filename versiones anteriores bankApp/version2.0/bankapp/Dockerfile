FROM mcr.microsoft.com/dotnet/sdk:7.0
WORKDIR /src
COPY . .
RUN dotnet publish "MyApi/bankapp.csproj" -c Release -o /app
ENTRYPOINT [ "dotnet", "bankapp.dll" ]