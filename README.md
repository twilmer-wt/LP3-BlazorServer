# LP3.BlazorServer

Sistema de gestion academica construido con **.NET 10 Blazor Server**, **Entity Framework Core** y **SQLite**.

---

## Estructura del proyecto

```
LP3.BlazorServer/
│
├── Program.cs                          ← Configuración, DI, middleware, migraciones
├── LP3.BlazorServer.csproj             ← Proyecto .NET 10
│
├── Application/Services/               ← Lógica de negocio
│   ├── IEstudianteService.cs           ← Contrato CRUD de estudiantes
│   ├── EstudianteService.cs            ← Implementación: GetAll, GetById, GetByMatricula,
│   │                                     Create, Update, Delete
│   ├── ICursoService.cs                ← Contrato CRUD de cursos
│   └── CursoService.cs                 ← Implementación: GetAll, GetById, GetByCodigo,
│                                        Create, Update, Delete
│
├── Data/
│   ├── ApplicationDbContext.cs         ← DbContext + interfaz IApplicationDbContext
│   ├── ApplicationUser.cs              ← Usuario Identity
│   ├── app.db                          ← Base de datos SQLite
│   ├── Migrations/                     ← Migraciones de EF Core
│   └── Repositories/                   ← Capa de acceso a datos
│       ├── IRepository.cs              ← Interfaz genérica CRUD (GetById, List, Add, Update, Remove)
│       ├── Repository.cs               ← Implementación genérica con EF Core
│       ├── IEstudianteRepository.cs    ← Extiende IRepository<Estudiante> + GetByMatricula
│       ├── EstudianteRepository.cs
│       ├── ICursoRepository.cs         ← Extiende IRepository<Curso> + GetByCodigo
│       └── CursoRepository.cs
│
├── Domain/                             ← Modelos de negocio
│   ├── Constants/ReglasDominio.cs      ← Constantes de validación
│   ├── Entities/
│   │   ├── Estudiante.cs               ← Id, Nombre, Apellido, Matricula, Email, Estado...
│   │   ├── Curso.cs                    ← Id, Nombre, Codigo, Creditos, Activo
│   │   └── Matriculacion.cs            ← Id, EstudianteId, CursoId, FechaInscripcion, Nota
│   └── Enums/
│       ├── EstadoEstudiante.cs         ← Activo, Inactivo, Egresado, Suspendido
│       └── TipoDocumento.cs            ← Cedula, Pasaporte, Licencia
│
├── Shared/                             ← DTOs y conversiones
│   ├── DTOs/
│   │   ├── EstudianteDto.cs            ← DTO listado estudiantes
│   │   ├── EstudianteFormDto.cs        ← DTO crear/editar estudiantes
│   │   ├── CursoDto.cs                 ← DTO listado cursos
│   │   └── CursoFormDto.cs             ← DTO crear/editar cursos
│   └── Extensions/
│       ├── EstudianteExtensions.cs     ← ToDto() / ToEntity()
│       └── CursoExtensions.cs          ← ToDto() / ToEntity()
│
├── Components/                         ← Presentación Blazor
│   ├── _Imports.razor                  ← Usings globales
│   ├── App.razor                       ← Layout HTML raíz
│   ├── Routes.razor                    ← Enrutador
│   ├── Layout/
│   │   ├── MainLayout.razor            ← Layout principal
│   │   ├── NavMenu.razor               ← Menú de navegación
│   │   └── ReconnectModal.razor        ← Modal de reconexión SignalR
│   ├── Account/                        ← Páginas de Identity (Login, Register, etc.)
│   └── Pages/
│       ├── Home.razor                  ← Página principal (/)
│       ├── Estudiantes.razor           ← CRUD estudiantes (/estudiantes)
│       ├── Cursos.razor                ← CRUD cursos (/cursos)
│       ├── Weather.razor               ← Datos meteorológicos de ejemplo
│       ├── Counter.razor               ← Contador de ejemplo
│       ├── Auth.razor                  ← Página con autenticación requerida
│       ├── Error.razor                 ← Página de error
│       └── NotFound.razor              ← Página 404
│
├── wwwroot/
│   ├── app.css                         ← Estilos personalizados
│   └── lib/bootstrap/dist/             ← Bootstrap 5 (CSS + JS)
│
├── appsettings.json                    ← Cadena de conexión SQLite
└── README.md                           ← Este archivo
```

---

## Requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

## Ejecutar

```bash
dotnet run
```

La aplicaci&oacute;n se inicia en `http://localhost:5000` (o el puerto indicado en consola).

## Endpoints

| Ruta            | Descripción                     |
|-----------------|---------------------------------|
| `/`             | Home                            |
| `/estudiantes`  | CRUD de estudiantes             |
| `/cursos`       | CRUD de cursos                  |

## Tecnologías

- .NET 10 Blazor Server (InteractiveServer)
- Entity Framework Core 10 + SQLite
- Bootstrap 5
- ASP.NET Core Identity
