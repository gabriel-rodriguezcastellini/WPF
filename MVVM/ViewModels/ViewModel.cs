using MVVM.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MVVM.ViewModels
{
    public class ViewModel : ViewModelBase
    {
        private readonly SelectedNameStore _selectedNameStore;
        private readonly ObservableCollection<string> _listNames;
        public IEnumerable<string> ListNames => _listNames;        

        public ViewModel(SelectedNameStore selectedNameStore)
        {
            _listNames = new ObservableCollection<string>
            {
                "Gabriel",
                "Sergi",
                "Axpe"
            };
            _selectedNameStore = selectedNameStore;
            _selectedNameStore.NameChanged += SelectedNameStore_NameChanged;
        }

        public string SelectedName
        {
            get
            {
                return _selectedNameStore?.Name;
            }
            set
            {
                OnPropertyChanged(nameof(SelectedName));
                _selectedNameStore.Name = value;
            }
        }

        protected override void Dispose()
        {
            _selectedNameStore.NameChanged -= SelectedNameStore_NameChanged;
            base.Dispose();
        }

        private void SelectedNameStore_NameChanged()
        {
            OnPropertyChanged(nameof(SelectedName));
        }        
    }
}
