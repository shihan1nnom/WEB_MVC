using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Prueba_1.Models;

namespace Prueba_1.Models
{
    public class InicializarBD:DropCreateDatabaseIfModelChanges<ContextoBD>
    {
        protected override void Seed(ContextoBD contexto)
        {
            var tipo_users = new List<Tipo_User>
            {
                new Tipo_User
                {
                    Nombre = "Administrador",
                    Usuario = true,
                    Categoria = true,
                    Activo = true,
                    TipoUser = true,
                    Sedes = true,
                    Ambientes = true,
                    Asignar = true,
                    Consulta = true,
                    CopiaSeguridad = true
                },
                new Tipo_User
                {
                    Nombre = "Auxiliar",
                    Usuario = false,
                    Categoria = false,
                    Activo = false,
                    TipoUser = false,
                    Sedes = false,
                    Ambientes = false,
                    Asignar = true,
                    Consulta = true,
                    CopiaSeguridad = false
                },

            };
            tipo_users.ForEach(t => contexto.Tipo_Users.Add(t));
            contexto.SaveChanges();

            var usuarios = new List<Usuario>
            { 
                new Usuario
                {
                    Nombre = "Administrador",
                    Apellido = "Admin",
                    TipoIdent = "Cedula de ciudadania",
                    NumIdent = "12345678",
                    Telefono = "3555555",
                    Email = "admin@admin.com",
                    Password = "Deathnote-7",
                    ConfirmPassword = "Deathnote-7",
                    TipoUserID = 1
                },
                new Usuario
                {
                    Nombre = "Auxiliar",
                    Apellido = "Auxi",
                    TipoIdent = "Cedula de ciudadania",
                    NumIdent = "12345678",
                    Telefono = "3222222",
                    Email = "auxi@auxi.com",
                    Password = "Deathnote-7",
                    ConfirmPassword = "Deathnote-7",
                    TipoUserID = 2
                },
            };
            usuarios.ForEach(u => contexto.Usuarios.Add(u));
            contexto.SaveChanges();
        }
    }
}