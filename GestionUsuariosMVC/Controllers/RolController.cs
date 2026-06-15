using System;
using System.Collections.Generic;
using System.Linq;
using GestionUsuariosMVC.Models;

namespace GestionUsuariosMVC.Controllers
{
    public class RolController
    {
        public List<Rol> ObtenerTodos()
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    return db.Roles.ToList();
                }
            }
            catch (Exception)
            {
                return new List<Rol>();
            }
        }
    }
}