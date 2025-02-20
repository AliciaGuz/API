# API de Productos

## Descripción

Esta es una API desarrollada en ASP.NET Core que permite la gestión de productos mediante operaciones CRUD (Crear, Leer, Actualizar y Eliminar). La API utiliza Entity Framework Core para la gestión de la base de datos y Dapper para consultas eficientes.

### Tecnologías Utilizadas

- ASP.NET Core

- Entity Framework Core

- Microsoft SQL Server

- Dapper (si aplica)

- Swagger (para documentación de la API)

## Estructura del Proyecto

API/
├── Controllers/

│   ├── ProductosController.cs  # Controlador de la API

│
├── Data/
│   ├── ApplicationDbContext.cs  # Contexto de base de datos

│
├── Entitys/
│   ├── Productos.cs  # Modelo de la entidad Productos

│
├── Repository/
│   ├── IProductRepository.cs  # Interfaz del repositorio
│   ├── ProductoRepository.cs  # Implementación del repositorio

│
├── Program.cs  # Configuración de la API

## Instalación y Configuración

## Prerrequisitos

### Antes de ejecutar la API, asegúrate de tener instalado:

- .NET 8

- SQL Server

## Configuración de la Base de Datos

1. Abre el archivo appsettings.json (o usa variables de entorno) y configura la cadena de conexión:

"ConnectionStrings": {
   
  "DefaultConnection": "Server=TU_SERVIDOR;Database=TU_BASE_DE_DATOS;User Id=TU_USUARIO;Password=TU_CONTRASEÑA;"
}

2. Ejecuta las migraciones (si aplicas Entity Framework Core):

- dotnet ef migrations add InitialCreate

- dotnet ef database update

## Ejecuta las migraciones (si aplicas Entity Framework Core):

- dotnet ef migrations add InitialCreate

- dotnet ef database update

## 🚀 Ejecución del Proyecto
Para ejecutar la API, usa los siguientes comandos:

```sh
# Restaurar paquetes NuGet
dotnet restore

# Compilar el proyecto
dotnet build

# Ejecutar la API
dotnet run

## 📌 Endpoints de la API

### 🔍 **Operaciones Disponibles**
|  Método    |  Endpoint               |  Descripción                      |
|------------|-------------------------|-----------------------------------|
| ** GET**   | `/api/productos`        |  Obtiene todos los productos      |
| ** GET**   | `/api/productos/{id}`   |  Obtiene un producto por su ID    |
| ** POST**  | `/api/productos`        |  Crea un nuevo producto           |
| ** PUT**   | `/api/productos/{id}`   |  Actualiza un producto existente  |
| ** DELETE**| `/api/productos/{id}`   |  Elimina un producto              |

---

Y ahí muere 
