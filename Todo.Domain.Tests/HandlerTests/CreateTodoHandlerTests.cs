using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.HandlerTests;

[TestClass]
public class CreateTodoHandlerTests

{
    // Mock - Criação de dados falsos
    // FakeRepositories

    private readonly CreateTodoCommands _invalidCommand = new CreateTodoCommands("", "", DateTime.Now);
    private readonly CreateTodoCommands _validCommand = new CreateTodoCommands("Título da Tarefa", "Matheus", DateTime.Now);
    private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());
    private GenericCommandResult _result = new GenericCommandResult();

    public CreateTodoHandlerTests()
    {
        _invalidCommand.Validate();
        _validCommand.Validate();
    }


    [TestMethod]
    public void Dado_um_comando_invalido_deve_interromper_a_execucao()
    {
        _result = (GenericCommandResult)_handler.Handle(_invalidCommand);
        Assert.AreEqual(_result.Success, false);
    }
    public void Dado_um_comando_valido_deve_criar_a_tarefa()
    {
        _result = (GenericCommandResult)_handler.Handle(_validCommand);
        Assert.AreEqual(_result.Success, true);
    }


}