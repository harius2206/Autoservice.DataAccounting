using Common.Interfaces;

public class OwnerModel : IIdentifiable, IKeyable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Key { get; set; }
}