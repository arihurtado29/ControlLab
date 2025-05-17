using ControlLab.Data;

namespace ControlLab.Control
{
    public interface IControlAnalisisClinicos
    {
        Task<List<AnalisisClinico>> GetAll();
        Task<AnalisisClinico> Get(int id);
        Task Add(AnalisisClinico analisisClinico);
        Task Update(AnalisisClinico analisisClinico);
        Task Delete(int id);
    }
}
