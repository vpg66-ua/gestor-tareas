# gestor-tareas
Esta aplicación abarcará autenticación de usuarios, gestión de proyectos, asignación de tareas y almacenamiento de archivos, con funcionalidades avanzadas y basadas en servicios de Azure.

# Organización del código
El código va a organizarse así:

## Capas:

- Models: Define los modelos de datos y la lógica de negocio.
- Controllers: Gestiona las peticiones HTTP y devuelve respuestas a la vista.
- Services: Gestiona la lógica de negocio avanzada y conecta con bases de datos y otros servicios.
- Repositories: Realiza operaciones directas con la base de datos.

## Carpetas:

- Controllers: Controladores que gestionan las peticiones.
- Models: Modelos de datos o entidades.
- Services: Servicios que encapsulan la lógica de negocio.
- Repositories: Acceso a datos, implementando el patrón repositorio.
- DTOs (Data Transfer Objects): Objetos que encapsulan datos específicos para la API.
- Configuración en appsettings.json: Almacena configuraciones como las conexiones a Azure y otros servicios de la nube.

## Base de datos
- Para la persistencia se utiliza una base de datos mysql en localhost.
