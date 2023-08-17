using XUnit_proficiency.Models;

namespace XUnit_proficiency.Interfaces
{
    public interface IPayerRespository
    {
        void Add(Payer payer);

        List<Payer> Get();
    }
}
