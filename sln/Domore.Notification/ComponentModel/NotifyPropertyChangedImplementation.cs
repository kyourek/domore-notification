using System.ComponentModel;

namespace Domore.ComponentModel {
    public class NotifyPropertyChangedImplementation : INotifyPropertyChanged {
        protected internal virtual void OnPropertyChanged(PropertyChangedEventArgs e) =>
            PropertyChanged?.Invoke(this, e);

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
