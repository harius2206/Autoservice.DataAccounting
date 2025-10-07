using System.Collections.Generic;

namespace Autoservice.UI.Searching
{
    public static class ModelsSearching
    {
        public static OwnerModel ById(this List<OwnerModel> models, int id)
        {
            foreach (OwnerModel model in models)
            {
                if (model.Id == id) return model;
            }
            return null;
        }
        public static ServiceModel ById(this List<ServiceModel> models, int id)
        {
            foreach (ServiceModel model in models)
            {
                if (model.Id == id) return model;
            }
            return null;
        }
    }
}