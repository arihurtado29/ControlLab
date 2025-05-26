using ControlLab.Data;

namespace ControlLab.Control
{
    public interface IControlQuimicos
    {
        Task<List<Quimico>> GetAll();
        Task<Quimico> Get(int id);
        Task Add(Quimico quimico);
        Task Update(Quimico quimico);
        Task Delete(int id);
    }
}

