# Book Reviews Application

## Descripción
Book Reviews es una aplicación web que permite a los usuarios gestionar libros y reseñas, registrarse, iniciar sesión y ver libros y reseñas disponibles. La aplicación incluye funcionalidades como autenticación de usuarios, operaciones CRUD (Crear, Leer, Actualizar, Eliminar) para libros y reseñas, y un sistema de puntuación.

## Tecnologías Utilizadas
- **Backend**: ASP.NET Core MVC, Entity Framework Core
- **Frontend**: Razor Pages, Bootstrap, HTML5, CSS3
- **Base de Datos**: SQL Server
- **Autenticación**: ASP.NET Identity
- **Despliegue**: Azure / IIS (opcional)
- **CI/CD**: GitHub Actions (opcional)

## Características
- **Gestión de Usuarios**: Registro, inicio de sesión, autenticación mediante ASP.NET Identity.
- **Libros**: Agregar, ver, editar y eliminar libros.
- **Reseñas**: Dejar comentarios y calificaciones para los libros.
- **Seguridad**: Hashing y salting de contraseñas.
  
## Requisitos Previos
Tener instalado lo siguiente en tu sistema:
- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads)
- [Node.js](https://nodejs.org/) (si decides usar Angular para el frontend)

## Configuración del Proyecto
Configurar la Base de Datos
Abre SQL Server Management Studio (SSMS) y crea una nueva base de datos, por ejemplo:
CREATE DATABASE BookReviewsDB;
- Actualiza la cadena de conexión en appsettings.json
- "ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=BookReviewsDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}

-  Aplicar Migraciones de Entity Framework
-  dotnet ef database update
-  dotnet run

### 1. Clonar el Repositorio
```bash
git clone https://github.com/tu-usuario/book-reviews.git
cd book-reviews

### Uso de Scripts SQL

Para descargar los scripts de la base de datos:

Abre SQL Server Management Studio (SSMS).
Haz clic derecho en tu base de datos > Tasks > Generate Scripts.
Selecciona Script entire database and all database objects.
Guarda el archivo .sql.

Alternativa usando sqlcmd
sqlcmd -S localhost -d BookReviewsDB -U sa -P YourPassword -Q "SELECT * FROM Books" -o "BookReviewsDB.sql"

