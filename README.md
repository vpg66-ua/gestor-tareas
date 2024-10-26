# gestor-tareas
Esta aplicación abarcará autenticación de usuarios, gestión de proyectos, asignación de tareas y almacenamiento de archivos, con funcionalidades avanzadas y basadas en servicios de Azure.

#Organización del código
En una aplicación de .NET Core o ASP.NET Core, el código va a organizarse así:

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

## Funcionalidades interesantes usando Azure
Para el proyecto de gestión de tareas y usuarios, se quieren aprovechar los siguientes servicios de Azure:

- Azure Active Directory B2C: Para gestionar autenticación y autorización, permitiendo que los usuarios se registren, inicien sesión y gestionen sus credenciales.

- Azure Cosmos DB o Azure SQL Database: Para almacenar y gestionar datos de usuarios, proyectos y tareas.

- Azure Blob Storage: Para almacenar archivos adjuntos, como documentos o imágenes asociados con proyectos o tareas.

- Azure Functions: Para tareas específicas o eventos desencadenados, como el envío de notificaciones automáticas.

- Azure Logic Apps: Para construir flujos de trabajo automatizados, como notificaciones de tareas o integraciones con otros servicios.

- Azure Monitor y Application Insights: Para el monitoreo de la aplicación en producción, con vistas sobre el rendimiento, las consultas y la actividad del usuario.
