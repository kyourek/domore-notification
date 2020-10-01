using System.ComponentModel;

#if !NET40
using System.Runtime.CompilerServices;
#endif

namespace Domore.Notification {
    using ComponentModel;

    public partial class Notifier : NotifyPropertyChangedImplementation {
        protected void NotifyPropertyChanged(string propertyName) =>
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));

        protected void NotifyPropertyChanged() =>
            NotifyPropertyChanged(string.Empty);

        protected internal bool Change<T>(
            ref T field,
            T value,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif
            ) {
            var equal = Equals(field, value);
            if (equal) return false;

            field = value;
            NotifyPropertyChanged(propertyName);
            return true;
        }

        protected internal T Change<T>(
            ref T field,
            T value,
            out bool changed,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) {
            changed = Change(ref field, value, propertyName);
            return field;
        }
    }
}
