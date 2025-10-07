using System.Collections.Generic;
using System.Text;

public class ModelsListsSet
{
    public readonly List<OwnerModel> OwnerModels = new List<OwnerModel>();
    public readonly List<TransportModel> TransportModels = new List<TransportModel>();
    public readonly List<ServiceModel> ServiceModels = new List<ServiceModel>();
    public readonly List<MeintenanceModel> MeintenanceModels = new List<MeintenanceModel>();

    public bool IsEmpty()
    {
        return OwnerModels.Count == 0
            && TransportModels.Count == 0
            && ServiceModels.Count == 0
            && MeintenanceModels.Count == 0;
    }

    public void Clear()
    {
        OwnerModels.Clear();
        TransportModels.Clear();
        ServiceModels.Clear();
        MeintenanceModels.Clear();
    }

    public string ToStatisticsString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Статистичні дані про об'єкти ПО");
        sb.AppendLine(" Представлено:");
        sb.AppendLine($"      {OwnerModels.Count} власники");
        sb.AppendLine($"      {TransportModels.Count} транспортні засоби");
        sb.AppendLine($"      {ServiceModels.Count} послуги");
        sb.AppendLine($"      {MeintenanceModels.Count} обслуговування");
        return sb.ToString();
    }
}