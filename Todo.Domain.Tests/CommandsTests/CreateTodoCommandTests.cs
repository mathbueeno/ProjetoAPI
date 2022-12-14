using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandsTests;

[TestClass]
public class CreateTodoCommandTests

{
    private readonly CreateTodoCommands _invalidCommand = new CreateTodoCommands("", "", DateTime.Now);
    private readonly CreateTodoCommands _validCommand = new CreateTodoCommands("Título da Tarefa", "Matheus", DateTime.Now);

    public CreateTodoCommandTests()
    {
        _invalidCommand.Validate();
        _validCommand.Validate();
    }


    [TestMethod]
    public void Dado_um_comando_invalido()
    {
        Assert.AreEqual(_invalidCommand.Valid, false);
    }

    [TestMethod]
    public void Dado_um_comando_valido()
    {
        Assert.AreEqual(_validCommand.Valid, true);
    }


}