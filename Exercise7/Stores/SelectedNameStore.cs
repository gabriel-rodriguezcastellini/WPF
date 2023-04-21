using System;

namespace Exercise7.Stores
{
    public class SelectedNameStore
    {
        private string _name;

        public string Name
        {
            get { return _name; }

            set 
            { 
                _name = value;
                NameChanged?.Invoke();
            }
        }

        public event Action NameChanged;
    }
}
