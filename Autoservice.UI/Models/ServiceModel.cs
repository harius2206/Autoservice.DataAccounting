using Common.Interfaces;
using System;

public class ServiceModel : IIdentifiable, IKeyable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal? Price { get; set; }
    public TimeSpan? Duration { get; set; }
    public TimeSpan? WarrantyPeriod { get; set; }
    public string Key { get; set; }
}