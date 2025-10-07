using System;

namespace Autoservice.DataAccounting.Browsing
{
    internal partial class SimpleBrowser
    {
        private static int CompareByName(OwnerModel model1, OwnerModel model2)
        {
            return string.Compare(model1.Name, model2.Name, StringComparison.CurrentCulture);
        }

        private void SortByName()
        {
            _listsSet.OwnerModels.Sort((m1, m2) => string.Compare(m1.Name, m2.Name, StringComparison.CurrentCulture));
        }

        private static int CompareByEmail(OwnerModel model1, OwnerModel model2)
        {
            return string.Compare(model1.Email, model2.Email, StringComparison.CurrentCulture);
        }

        private void SortByEmail()
        {
            _listsSet.OwnerModels.Sort((m1, m2) => string.Compare(m1.Email, m2.Email, StringComparison.CurrentCulture));
        }

        private static int CompareByAddress(OwnerModel model1, OwnerModel model2)
        {
            return string.Compare(model1.Address, model2.Address, StringComparison.CurrentCulture);
        }

        private void SortByAddress()
        {
            _listsSet.OwnerModels.Sort((m1, m2) => string.Compare(m1.Address, m2.Address, StringComparison.CurrentCulture));
        }

        private static int CompareByServiceName(ServiceModel model1, ServiceModel model2)
        {
            return string.Compare(model1.Name, model2.Name, StringComparison.CurrentCulture);
        }

        private void SortByServiceName()
        {
            _listsSet.ServiceModels.Sort((m1, m2) => string.Compare(m1.Name, m2.Name, StringComparison.CurrentCulture));
        }

        //private static int CompareByServicePrice(ServiceModel model1, ServiceModel model2)
        //{
        //    return model1.Price.CompareTo(model2.Price);
        //}

        //private void SortByServicePrice()
        //{
        //    _listsSet.ServiceModels.Sort((m1, m2) => m1.Price.CompareTo(m2.Price));
        //}

        //private static int CompareByServiceDuration(ServiceModel model1, ServiceModel model2)
        //{
        //    return model1.Duration.CompareTo(model2.Duration);
        //}

        //private void SortByServiceDuration()
        //{
        //    _listsSet.ServiceModels.Sort((m1, m2) => m1.Duration.CompareTo(m2.Duration));
        //}
    }
}