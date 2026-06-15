# Sistema de Control de Usuarios - Arquitectura MVC

Aplicación de escritorio desarrollada en C# con Windows Forms y .NET. El sistema implementa una separación estricta de responsabilidades mediante el patrón de diseño Modelo-Vista-Controlador (MVC), gestionando la persistencia de datos con Entity Framework Core y SQL Server (LocalDB).

## 🛠️ Operaciones Implementadas (CRUD)
* **Altas:** Permite el registro de nuevos usuarios vinculándolos a un rol predefinido.
* **Consultas:** Despliegue automático de la información en un componente DataGridView, mapeando las relaciones correspondientes.
* **Modificaciones:** Edición de registros existentes mediante la selección directa en la tabla (doble clic).
* **Seguridad:** Filtros de validación para evitar campos vacíos y protección nativa contra inyección SQL mediante expresiones LINQ.

## 📐 División del Código (Estructura)
* **Capa de Presentación (UI):** `Form1.cs` - Controla los eventos gráficos y la interacción con el usuario.
* **Capa de Negocio (Controladores):** `UsuarioController.cs` y `RolController.cs` - Gestionan el flujo de datos y las reglas del sistema.
* **Capa de Datos y Entidades:** `Usuario.cs`, `Rol.cs` y `ApplicationDbContext.cs` - Estructura del dominio y configuración del ORM.

## 🗄️ Persistencia y Base de Datos
La estructura relacional se adjunta de forma independiente en la raíz del proyecto para su evaluación:
* **Script SQL:** `script_base_datos.sql` (Contiene las sentencias DDL para la creación de tablas e inserciones iniciales de prueba).

## 📹 Enlace de Evidencia Visual
*(Coloca aquí la URL de tu video demostrativo de funcionamiento)*