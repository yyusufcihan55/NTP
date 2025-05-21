# Hata ayıklama kapsayıcınızı özelleştirme ve Visual Studio’nun daha hızlı hata ayıklama için görüntülerinizi derlemek üzere bu Dockerfile'ı nasıl kullandığı hakkında bilgi edinmek için https://aka.ms/customizecontainer sayfasına bakın.

# Kapsayıcıları oluşturan veya çalıştıran konak makinelerinin işletim sistemine bağlı olarak FROM deyiminde belirtilen görüntünün değiştirilmesi gerekir.
# Daha fazla bilgi edinmek için https://aka.ms/containercompat sayfasına bakın

# Bu aşama, VS'den hızlı modda çalıştırıldığında kullanılır (Hata ayıklama yapılandırması için varsayılan olarak ayarlıdır)
FROM mcr.microsoft.com/dotnet/runtime:8.0-nanoserver-1809 AS base
WORKDIR /app


# Bu aşama, hizmet projesini oluşturmak için kullanılır
FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-1809 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Hayvanlarrİnterface.csproj", "."]
RUN dotnet restore "./Hayvanlarrİnterface.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./Hayvanlarrİnterface.csproj" -c %BUILD_CONFIGURATION% -o /app/build

# Bu aşama, son aşamaya kopyalanacak hizmet projesini yayımlamak için kullanılır
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Hayvanlarrİnterface.csproj" -c %BUILD_CONFIGURATION% -o /app/publish /p:UseAppHost=false

# Bu aşama üretimde veya VS'den normal modda çalıştırıldığında kullanılır (Hata Ayıklama yapılandırması kullanılmazken varsayılan olarak ayarlıdır)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hayvanlarrİnterface.dll"]