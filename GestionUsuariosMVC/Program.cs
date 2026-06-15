using System;
using System.Linq;
using System.Windows.Forms;
using GestionUsuariosMVC.Models;
using GestionUsuariosMVC.Views;

namespace GestionUsuariosMVC
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                using (var db = new ApplicationDbContext())
                {
                    // Borra la base de datos si quedó corrupta o incompleta
                    db.Database.EnsureDeleted();

                    // Crea la base de datos con TODAS las tablas de tus modelos (Roles y Usuarios)
                    db.Database.EnsureCreated();

                    // Inserta los roles iniciales si la tabla está vacía
                    if (!db.Roles.Any())
                    {
                        db.Roles.Add(new Rol { NombreRol = "Administrador" });
                        db.Roles.Add(new Rol { NombreRol = "Operador" });
                        db.Roles.Add(new Rol { NombreRol = "Auditor" });
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar datos: " + ex.Message);
            }

            Application.Run(new Form1());
        }
    }
}