using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using GestionUsuariosMVC.Models;

namespace GestionUsuariosMVC.Controllers
{
    public class UsuarioController
    {
        public List<Usuario> ObtenerTodos()
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    return db.Usuarios.Include(u => u.Rol).ToList();
                }
            }
            catch (Exception)
            {
                return new List<Usuario>();
            }
        }

        public bool Crear(Usuario usuario)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    db.Usuarios.Add(usuario);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Actualizar(Usuario usuario)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    var usuarioEnBase = db.Usuarios.Find(usuario.IdUsuario);
                    if (usuarioEnBase != null)
                    {
                        usuarioEnBase.Nombre = usuario.Nombre;
                        usuarioEnBase.Correo = usuario.Correo;
                        usuarioEnBase.IdRol = usuario.IdRol;
                        db.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}