using System.ComponentModel;

#if !NET40
using System.Runtime.CompilerServices;
#endif

namespace Domore.Notification {
    using ComponentModel;

    public partial class Notifier : NotifyPropertyChangedImplementation {
        protected void NotifyPropertyChanged(string propertyName) =>
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));

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
            T oldValue,
            T newValue,
            out bool changed,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) {
            changed = Change(ref oldValue, newValue, propertyName);
            return oldValue;
        }

        protected internal T Change<T>(
            T oldValue,
            T newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);

        protected internal bool Change<T>(
            ref string field,
            string value,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif
            ) {
            var equal = field == value;
            if (equal) return false;

            field = value;
            NotifyPropertyChanged(propertyName);
            return true;
        }

        protected internal string Change(
            string oldValue,
            string newValue,
            out bool changed,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) {
            changed = Change(ref oldValue, newValue, propertyName);
            return oldValue;
        }

        protected internal string Change(
            string oldValue,
            string newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);
    }
}
