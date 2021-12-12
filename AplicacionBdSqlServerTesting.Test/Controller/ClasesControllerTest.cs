using AplicacionBdSqlServer.Controllers;
using AplicacionBdSqlServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionBdSqlServerTesting.Test.Controller
{
    [TestFixture]
    public  class ClasesControllerTest
    {
        [Test]
        public void MiAula()
        {
            var iqueriable = new Mock<IQueryable<Curso>>();
            var dbsetMock = new Mock<DbSet<Curso>>();
            dbsetMock.Setup(o => o.Include("")).Returns(iqueriable.Object);

            var contextMock = new Mock<IClasesUpnContext>();
            contextMock.Setup(o => o.Cursos).Returns(dbsetMock.Object);

            var controller = new ClasesController(contextMock.Object);
            var view  = controller.MiAula() as ViewResult;

            Assert.AreEqual("MiAula", view.ViewName);
        }
    }
}
