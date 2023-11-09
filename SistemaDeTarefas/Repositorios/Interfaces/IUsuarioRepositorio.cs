using SistemaDeTarefas.Models; //Utilizando Models do Sistema de Tarefas

namespace SistemaDeTarefas.Repositorios.Interfaces
    
{
    public interface IUsuarioRepositorio //Interface com os contratos que serão obrigatorios para quem for implementar
    {
    Task<List<UsuarioModel>> BuscarTodosUsuarios(); //Task de Buscar Todos os Usuarios

    Task<UsuarioModel> BuscarPorId(int id); //Task de Buscar usuario pelo ID
    Task<UsuarioModel> Adicionar(UsuarioModel usuario); //Task de Add usuario 
    Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id); //Task de Atualizar o usuario passando Id 

    Task<bool> Apagar(int id); //Task para apagar o usuario pelo Id
    }
}
