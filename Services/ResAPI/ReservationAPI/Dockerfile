#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Services/ResAPI/ReservationAPI/Reservation.API.csproj", "Services/ResAPI/ReservationAPI/"]
COPY ["Services/ResAPI/Reservation.API.Models/Reservation.API.Models.csproj", "Services/ResAPI/Reservation.API.Models/"]
COPY ["Services/ResAPI/Reservation.API.Services/Reservation.API.Services.csproj", "Services/ResAPI/Reservation.API.Services/"]
COPY ["Services/ResAPI/ReservationAPI.Infrastructure/ReservationAPI.Infrastructure.csproj", "Services/ResAPI/ReservationAPI.Infrastructure/"]
RUN dotnet restore "Services/ResAPI/ReservationAPI/Reservation.API.csproj"
COPY . .
WORKDIR "/src/Services/ResAPI/ReservationAPI"
RUN dotnet build "Reservation.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Reservation.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Reservation.API.dll"]