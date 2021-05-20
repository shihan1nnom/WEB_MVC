using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prueba_1.Controllers;
using Prueba_1.Models;

namespace Prueba_1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private UsuarioController controlador;
        private ContextoBD _BD;

        [TestInitialize]
        public void SetupControlador()
        {
            controlador = new UsuarioController();
            _BD = new ContextoBD();
        }

        [TestMethod]
        public void IndexUsuario()
        {
            var resultado = controlador.Index() as ViewResult;
            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void DetalleUsuarioNulo()
        {
            var resultado = controlador.Detalle(null) as ViewResult;
            Assert.AreEqual("ID de usuario nulo", resultado.ViewBag.Error);
        }

        [TestMethod]
        public void CrearUsuario()
        {
            var _usuario = new Usuario()
            {
                Nombre = "Leonardo",
                Apellido = "Menza",
                TipoIdent = "Cedula de ciudadania",
                NumIdent = "12345678",
                Telefono = "3555555",
                Email = "admin@admin.com",
                Password = "Deathnote-7",
                ConfirmPassword = "Deathnote-7",
                TipoUserID = 2
            };
            var resultado = controlador.Crear(_usuario);
            Assert.IsNull(resultado);
        }
    }
}
