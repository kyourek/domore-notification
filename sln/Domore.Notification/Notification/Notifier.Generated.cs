#if !NET40
using System.Runtime.CompilerServices;
#endif

namespace Domore.Notification {
    public partial class Notifier {
        protected internal bool Change(
            ref bool field,
            bool value,
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

        protected internal bool Change(
            bool oldValue,
            bool newValue,
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

        protected internal bool Change(
            bool oldValue,
            bool newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);

        protected internal bool Change(
            ref byte field,
            byte value,
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

        protected internal byte Change(
            byte oldValue,
            byte newValue,
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

        protected internal byte Change(
            byte oldValue,
            byte newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);

        protected internal bool Change(
            ref sbyte field,
            sbyte value,
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

        protected internal sbyte Change(
            sbyte oldValue,
            sbyte newValue,
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

        protected internal sbyte Change(
            sbyte oldValue,
            sbyte newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);

        protected internal bool Change(
            ref char field,
            char value,
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

        protected internal char Change(
            char oldValue,
            char newValue,
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

        protected internal char Change(
            char oldValue,
            char newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);

        protected internal bool Change(
            ref decimal field,
            decimal value,
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

        protected internal decimal Change(
            decimal oldValue,
            decimal newValue,
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

        protected internal decimal Change(
            decimal oldValue,
            decimal newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);

        protected internal bool Change(
            ref double field,
            double value,
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

        protected internal double Change(
            double oldValue,
            double newValue,
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

        protected internal double Change(
            double oldValue,
            double newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);

        protected internal bool Change(
            ref float field,
            float value,
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

        protected internal float Change(
            float oldValue,
            float newValue,
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

        protected internal float Change(
            float oldValue,
            float newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);

        protected internal bool Change(
            ref int field,
            int value,
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

        protected internal int Change(
            int oldValue,
            int newValue,
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

        protected internal int Change(
            int oldValue,
            int newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);

        protected internal bool Change(
            ref uint field,
            uint value,
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

        protected internal uint Change(
            uint oldValue,
            uint newValue,
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

        protected internal uint Change(
            uint oldValue,
            uint newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);

        protected internal bool Change(
            ref long field,
            long value,
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

        protected internal long Change(
            long oldValue,
            long newValue,
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

        protected internal long Change(
            long oldValue,
            long newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);

        protected internal bool Change(
            ref ulong field,
            ulong value,
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

        protected internal ulong Change(
            ulong oldValue,
            ulong newValue,
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

        protected internal ulong Change(
            ulong oldValue,
            ulong newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);

        protected internal bool Change(
            ref short field,
            short value,
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

        protected internal short Change(
            short oldValue,
            short newValue,
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

        protected internal short Change(
            short oldValue,
            short newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);

        protected internal bool Change(
            ref ushort field,
            ushort value,
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

        protected internal ushort Change(
            ushort oldValue,
            ushort newValue,
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

        protected internal ushort Change(
            ushort oldValue,
            ushort newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);
    }
}
