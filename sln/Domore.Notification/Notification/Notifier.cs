using System.ComponentModel;
#if !NET40
using System.Runtime.CompilerServices;
#endif

namespace Domore.Notification {
    using ComponentModel;

    public partial class Notifier : NotifyPropertyChangedImplementation {
#if !NET40
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        protected void NotifyPropertyChanged(string propertyName) {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

#if !NET40
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        protected void NotifyPropertyChanged() {
            NotifyPropertyChanged(string.Empty);
        }
    }
}
