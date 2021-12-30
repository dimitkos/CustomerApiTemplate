namespace Shared
{
    public class AddCustomer
    {
        public int Id { get; }
        public string Name { get; }
        public string Email { get; }
        public string Address { get; }

        public AddCustomer(int id, string name, string email, string address)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
        }
    }

    public class SearchCustomers
    {
        public string? Name { get; }
        public string? Email { get; }
        public string? Address { get; }
        public int? Skip { get; }
        public int? PageSize { get; }

        public SearchCustomers(string? name = null, string? email = null, string? address = null, int? skip = null, int? pageSize = null)
        {
            Name = name;
            Email = email;
            Address = address;
            Skip = skip;
            PageSize = pageSize;
        }
    }
}
