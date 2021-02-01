using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Repository
{
    public interface IPersonRepository : IPersonRepository<Person>
    {
        Person Disable(long id);
    }
}
