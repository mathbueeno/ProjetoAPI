using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandsTests;

[TestClass]
public class CreateTodoCommandTests
{
    [TestMethod]
    public void Dado_um_comando_invalido()
    {
        var command = new CreateTodoCommands("", "", DateTime.Now);
        command.Validate();
        Assert.AreEqual(command.Valid, false);
    }

    [TestMethod]
    public void Dado_um_comando_valido()
    {
        var command = new CreateTodoCommands("Título da Tarefa", "Matheus", DateTime.Now);
        command.Validate();
        Assert.AreEqual(command.Valid, true);
    }


}