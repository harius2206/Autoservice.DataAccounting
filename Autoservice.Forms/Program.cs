//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Autoservice.Forms.Views;
//using Autoservice.UI.Data;
//using Common.Selection;



using System;
using static System.Net.Mime.MediaTypeNames;

namespace Autoservice.Forms
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new FOwnersView());
            //Application.Run(new FServicesView());
            //Application.Run(new FTransportsView());
            //Application.Run(CreateFOwnersView());
            //Application.Run(CreateFTransportsView());
        }
        //static ModelsListsSet _listsSet = new ModelsListsSet();
        //        static FOwnersView _fOwnersView;
        //        static FTransportsView _fTransportsView;
        //        //private static FOwnersView CreateFOwnersView()
        //        //{
        //        //    _fOwnersView = new FOwnersView();
        //        //    _fOwnersView.TestingDataCreation += FOwnersView_TestingDataCreation;
        //        //    _fOwnersView.CrudAction += FOwnersView_CrudAction;
        //        //    return _fOwnersView;

        //        //}
        //        //private static FTransportsView CreateFTransportsView()
        //        //{
        //        //    _fTransportsView = new FTransportsView();
        //        //    _fTransportsView.TestingDataCreation += FTransportsView_TestingDataCreation;
        //        //    _fTransportsView.CrudAction += FTransportsView_CrudAction;
        //        //    return _fTransportsView;

        //        //}

        //        //private static void FOwnersView_TestingDataCreation(object sender, EventArgs e)
        //        //{
        //        //    _listsSet.CreateTestingModels();
        //        //    _fOwnersView.UpdateInfo(_listsSet.OwnerModels);

        //        //}
        //        //private static void FTransportsView_TestingDataCreation(object sender, EventArgs e)
        //        //{
        //        //    _listsSet.CreateTestingModels();
        //        //    _fTransportsView.UpdateInfo(_listsSet.TransportModels);

        //        //}
        //        private static void FOwnersView_CrudAction(object sender,
        //        Common.Proccesing.Events.CrudActionEventArgs e)
        //        {
        //            //throw new NotImplementedException();
        //            string message = string.Format("{0}, {1}",
        //                e.CrudMode, KeyableMethods.GetKey(e.Model));
        //            MessageBox.Show(message, "Обробка події CrudAction");
        //        }

        //        private static void FTransportsView_CrudAction(object sender,
        //        Common.Proccesing.Events.CrudActionEventArgs e)
        //        {
        //            //throw new NotImplementedException();
        //            string message = string.Format("{0}, {1}",
        //                e.CrudMode, KeyableMethods.GetKey(e.Model));
        //            MessageBox.Show(message, "Обробка події CrudAction");
        //        }

    }
}
