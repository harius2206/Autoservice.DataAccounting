using Common.Entities;
using Common.Interfaces;
using Common.Processing.Events;
using Common.Processing.Interfaces;
using Common.Processing.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Common.Processing.Editing
{
    public abstract class EntityEditor<TEntity, TModel> : IEntityEditor<TModel>
        where TEntity : Entity where TModel : class, IIdentifiable, IKeyable
    {

        protected ICollection<TEntity> Collection { get; set; }

        protected IEnumerable<TEntity> SortedObjects { get; set; }

        protected EntityEditor(ICollection<TEntity> collection)
        {
            Collection = collection;
            SortedObjects = Collection.OrderBy(e => e.Key);
        }

        public abstract IEnumerable<TModel> GetModels();

        public bool Create(TModel model)
        {
            if (CheckCreation(model))
            {
                Console.WriteLine($"[EntityEditor] Create: {typeof(TEntity).Name} Id before: {model.Id}");
                model.Id = Collection.Any() ? Collection.Select(e => e.Id).Max() + 1 : 1;
                AddNewObject(model);
                Console.WriteLine($"[EntityEditor] Create: {typeof(TEntity).Name} Id after: {model.Id}, Collection.Count: {Collection.Count}");
                OnDataChanged();
                return true;
            }
            Console.WriteLine($"[EntityEditor] Create: {typeof(TEntity).Name} - CheckCreation failed");
            return false;
        }

        protected abstract bool CheckCreation(TModel model);

        protected abstract void AddNewObject(TModel model);

        public bool Update(TModel model)
        {
            if (CheckUpdating(model))
            {
                var obj = Collection.FirstOrDefault(e => e.Id == model.Id);
                UpdateObject(model, obj);
                OnDataChanged();
                return true;
            }
            return false;
        }

        protected abstract bool CheckUpdating(TModel model);

        protected abstract void UpdateObject(TModel model, TEntity obj);

        public bool Delete(TModel model)
        {
            if (CheckDeleting(model))
            {
                RemoveObject(model);
                OnDataChanged();
                return true;
            }
            Console.WriteLine($"[EntityEditor] Delete: {typeof(TEntity).Name} - CheckDeleting failed");
            return false;
        }

        protected abstract bool CheckDeleting(TModel model);

        protected virtual void RemoveObject(TModel model)
        {
            var obj = Collection.FirstOrDefault(e => e.Id == model.Id);
            if (obj != null)
            {
                Collection.Remove(obj);
                Console.WriteLine($"[EntityEditor] RemoveObject: {typeof(TEntity).Name} Id={model.Id} removed. Collection.Count: {Collection.Count}");
            }
            else
            {
                Console.WriteLine($"[EntityEditor] RemoveObject: {typeof(TEntity).Name} Id={model.Id} not found.");
            }
            OnDataChanged();
        }

        public event EventHandler<ActionInfoEventArgs> ActionError;

        protected void OnActionError(ActionInfoEventArgs eventArgs)
        {
            if (ActionError != null)
            {
                ActionError(this, eventArgs);
            }
        }

        public void RunAction(CrudMode mode, TModel model)
        {
            switch (mode)
            {
                case CrudMode.Creation: Create(model); break;
                case CrudMode.Updating: Update(model); break;
                case CrudMode.Deleting: Delete(model); break;
            }
        }

        public abstract void Save();

        public event EventHandler<EventArgs> DataChanged;

        protected void OnDataChanged()
        {
            if (DataChanged != null)
            {
                DataChanged(this, EventArgs.Empty);
            }
        }
    }
}