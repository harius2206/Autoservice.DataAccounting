using Common.Interfaces;

public class TransportModel : IIdentifiable, IKeyable
{
    public int Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Number { get; set; }
    public string Description { get; set; }
    public string OwnerKey { get; set; }
    public string ParentKey { get; set; }
    public string ParentMake { get; set; }   
    public string ParentModel { get; set; }  
    public string Key { get; set; }
}