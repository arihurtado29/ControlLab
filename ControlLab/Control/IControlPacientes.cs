using ControlLab.Data;

namespace ControlLab.Control
{
    public interface IControlPacientes
    {
        Task<List<Paciente>> GetAll();
        Task<Paciente> Get(int id);
        Task Add(Paciente paciente);
        Task Update(Paciente paciente);
        Task Delete(int id);
        Task<bool> SePuedeBorrar(int id);
    }
}
