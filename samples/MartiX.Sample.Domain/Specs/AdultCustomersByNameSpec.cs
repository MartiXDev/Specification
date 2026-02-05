using MartiX.Specification;

namespace MartiX.Sample.Domain.Specs;

public class AdultCustomersByNameSpec : Specification<Customer>
{
    public AdultCustomersByNameSpec(string nameSubstring)
    {
        Query.IsAdult()
            .NameIncludes(nameSubstring);
    }
}
