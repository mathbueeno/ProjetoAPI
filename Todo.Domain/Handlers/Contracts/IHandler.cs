

using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Handlers.Contracts
{

    // Tipo T - Gerencia um ou mais comandos
    // Restrição - Sempre pode chmar interface IHandler de T, desde que T seja um ICommand.
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}