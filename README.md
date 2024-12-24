# Dotnet Skeleton
Aplikasi dotnet yang sudah dengan SSL dan Docker juga Swagger untuk dokumentasi API

# Now with Docker!
1. Buat image dulu dengan `docker build -t ad1eedotnet/skeleton:runtime .`
2. Buat sertifikat untuk SSL terlebih dulu untuk menjalankan aplikasi
3. Lakukan `docker-compose up -d`

### .env
```
ASPNETCORE_Kestrel_Certificates_Default_Password=
ASPNETCORE_Kestrel_Certificates_Default_Path=
SEKRITDOKUMINTS=

POSTGRES_USER=
POSTGRES_PASSWORD=
POSTGRES_DB=
```