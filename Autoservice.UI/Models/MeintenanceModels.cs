using Common.Interfaces;
using System;

public class MeintenanceModel : IIdentifiable, IKeyable
{
    public int Id { get; set; }
    public string TransportKey { get; set; }
    public string ServiceKey { get; set; }
    public DateTime? Date { get; set; }
    public decimal? Cost { get; set; }
    public string Note { get; set; }
    public string Key { get; set; }
}