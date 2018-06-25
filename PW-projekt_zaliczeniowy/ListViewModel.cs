using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kowalski.PW_projekt_zaliczeniowy.PW_projekt_zaliczeniowy
{
    public abstract class ListViewModel<T> : ViewModelBase where T: ViewModelBase
    {

        public ObservableCollection<T> Items { get; set; } = new ObservableCollection<T>();

        public T _selectedItem;
        public T SelectedItem
        {
            get
            {
                return _selectedItem;
            }

            set
            {
                if (!EqualityComparer<T>.Default.Equals(_selectedItem, value))
                {
                    _selectedItem = value;
                    RaisePropertyChanged("SelectedItem");
                }
            }
        }

        public T _editedItem;
        public T EditedItem
        {
            get
            {
                return _editedItem;
            }

            set
            {
                if (!EqualityComparer<T>.Default.Equals(_editedItem, value))
                {
                    _editedItem = value;
                    RaisePropertyChanged("EditedItem");
                }
            }
        }

        public ICommand DeleteItem_Click { get { return new RelayCommand(DeleteItemExecute, CanDeleteItemExecute); } }

        private void DeleteItemExecute()
        {
            Items.Remove(SelectedItem);
        }

        private bool CanDeleteItemExecute()
        {
            //Some logic
            return true;
        }



        public ICommand AddNewItem_Click { get { return new RelayCommand(AddNewItemExecute, CanAddNewItemExecute); } }

        private void AddNewItemExecute()
        {
            EditedItem.Validate();
            if (!EditedItem.HasErrors)
            {
                Items.Add(EditedItem);
                SetUpNewClubToAdd();
            }
        }

        

        private bool CanAddNewItemExecute()
        {
            //Some logic
            return true;
        }

        public ListViewModel()
        {
            Initialize();
            SetUpNewClubToAdd();
        }

        protected abstract void Initialize();

        protected abstract void SetUpNewClubToAdd();
    }
}
