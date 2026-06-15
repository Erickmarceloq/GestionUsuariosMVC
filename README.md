# Sistema de Control de Usuarios - Arquitectura MVC

Aplicación de escritorio desarrollada en C# con Windows Forms y .NET. El sistema implementa una separación estricta de responsabilidades mediante el patrón de diseño Modelo-Vista-Controlador (MVC), gestionando la persistencia de datos con Entity Framework Core y SQL Server (LocalDB).

## Operaciones Implementadas (CRUD)
Altas: Registro de nuevos usuarios con asignación de roles.
Consultas: Despliegue de datos en DataGridView con carga de relaciones.
Modificaciones: Edición de registros mediante selección directa en la tabla.
Seguridad: Validación de campos obligatorios y protección contra inyección SQL mediante LINQ.

## Estructura del Proyecto
Capa de Presentación (UI): Form1.cs - Gestión de eventos gráficos y navegación.
Capa de Negocio (Controladores): UsuarioController.cs y RolController.cs - Lógica de flujo y reglas de negocio.
Capa de Datos y Entidades: Usuario.cs, Rol.cs y ApplicationDbContext.cs - Definición de dominio y configuración del ORM.

## Persistencia y Base de Datos
La estructura relacional se encuentra en la raíz del proyecto para su revisión:
Script SQL: script_base_datos.sql (Sentencias DDL para creación de tablas e inserciones iniciales).
