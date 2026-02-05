using MartiX.Sample.Domain.Filters;
using MartiX.Specification;

namespace MartiX.Sample.Domain.Specs;

public class CustomerSpec : Specification<Customer>
{
    public CustomerSpec()
    {
        Query.Include(c => c.Addresses)
            .ApplyOrdering()
            .TagWith("List all customers.");
    }

    public CustomerSpec(CustomerFilter filter)
    {
        Query.Include(x => x.Addresses)
            .Where(c => c.Age >= filter.AgeFrom, filter.AgeFrom is not null)
            .Where(c => c.Age <= filter.AgeTo, filter.AgeTo is not null)
            .Where(c => c.Name == filter.Name, filter.Name is not null)
            .ApplyOrdering(filter)
            .TagWith("List customers filtered by user inputs.");
    }
}
