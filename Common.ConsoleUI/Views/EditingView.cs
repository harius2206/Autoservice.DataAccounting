using Common.ConsoleIO;
using Common.Interfaces;
using Common.Processing.Events;
using Common.Processing.Interfaces;
using Common.Processing.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Common.ConsoleUI.Views
{
    public abstract class EditingView<TModel> : BaseCommandController, IEditingView<TModel>
        where TModel : class, IIdentifiable, IKeyable
    {

        public event EventHandler<CrudActionEventArgs> CrudAction;

        protected void OnCrudAction(CrudActionEventArgs eventArgs)
        {
            CrudAction?.Invoke(this, eventArgs);
        }

        public event EventHandler<EventArgs> TestingDataCreation;


        protected List<TModel> Models { get; private set; }

        public void UpdateInfo(List<TModel> models)
        {
            //throw new NotImplementedException();
            Models = models;
        }

        private bool ModelsIsNotEmpty() => Models?.Any() ?? false;

        protected override MenuItemEx[] IniMenuItems()
        {
            return new MenuItemEx[] {
                new MenuItemEx("назад", null),
                new MenuItemEx("дані як текст", ShowAsText, true, ModelsIsNotEmpty),
                new MenuItemEx("детально про...", ShowObjectDetails, true, ModelsIsNotEmpty),
                new MenuItemEx("додати запис...", Add),
                new MenuItemEx("редагувати запис...", Edit),
                new MenuItemEx("видалити запис...", Remove, false, ModelsIsNotEmpty),
                new MenuItemEx("сортувати", SortMenu, false, ModelsIsNotEmpty), //-------
                new MenuItemEx("зберегти дані", Save),


            };
        }

        protected override void PrepareScreen()
        {
            //throw new NotImplementedException();
            Console.Clear();
            OutTable();
        }

       
        protected abstract void OutTable();

        protected abstract void ShowAsText();

        private TModel SelectModel()
        {
            int id = Inputting.InputInt32(" Введіть Id запису");
            TModel model = Models.FirstOrDefault(e => e.Id == id);
            if (model == null)
            {
                Console.WriteLine("В списку немає запису з Id рівним {0}", id);
            }
            return model;
        }

        private void ShowObjectDetails()
        {
            TModel model = SelectModel();
            if (model == null)
                return;
            ShowObjectDetails(model);
        }

        protected abstract void ShowObjectDetails(TModel model);

        public void Add()
        {
            TModel model;
            Create(out model);
            OnCrudAction(new CrudActionEventArgs(CrudMode.Creation, model));
        }

        protected abstract void Create(out TModel model);

        private void Edit()
        {
            TModel model = SelectModel();
            if (model == null)
                return;
            Update(model);
            OnCrudAction(new CrudActionEventArgs(CrudMode.Updating, model));
        }

        protected abstract void Update(TModel model);

        private void Remove()
        {
            TModel model = SelectModel();
            if (model == null)
                return;
            OnCrudAction(new CrudActionEventArgs(CrudMode.Deleting, model));
        }

        public event EventHandler<EventArgs> Saving;

        private void Save()
        {
            if (Saving != null) Saving(this, EventArgs.Empty);
        }

        protected virtual void SortMenu()
        {
        }

    }
}
