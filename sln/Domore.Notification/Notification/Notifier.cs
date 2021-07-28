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
#if !NET40
            [CallerMemberName]
#endif
            string propertyName
#if !NET40
            = null
#endif
            ) {
            var equal = Equals(field, value);
            if (equal) return false;

            field = value;
            NotifyPropertyChanged(propertyName);
            return true;
        }

        protected internal bool Change<T>(
            ref T field,
            T value,
#if !NET40
            [CallerMemberName]
#endif
            string propertyName
#if !NET40
            = null
#endif
            ,
            params string[] dependentPropertyNames
            ) {
            var changed = Change(ref field, value, propertyName);
            if (changed) {
                if (dependentPropertyNames != null) {
                    foreach (var dependentPropertyName in dependentPropertyNames) {
                        NotifyPropertyChanged(dependentPropertyName);
                    }
                }
            }
            return changed;
        }

        protected internal T Change<T>(
            ref T field,
            T value,
            out bool changed,
#if !NET40
            [CallerMemberName]
#endif
            string propertyName
#if !NET40
            = null
#endif
            ) {
            changed = Change(ref field, value, propertyName);
            return field;
        }
    }
}
