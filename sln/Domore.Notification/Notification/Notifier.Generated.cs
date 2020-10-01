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
            ref bool field,
            bool value,
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
            ref byte field,
            byte value,
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
            ref sbyte field,
            sbyte value,
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
            ref char field,
            char value,
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
            ref decimal field,
            decimal value,
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
            ref double field,
            double value,
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
            ref float field,
            float value,
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
            ref int field,
            int value,
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
            ref uint field,
            uint value,
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
            ref long field,
            long value,
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
            ref ulong field,
            ulong value,
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
            ref short field,
            short value,
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
            ref ushort field,
            ushort value,
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

        protected internal bool Change(
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
            ref string field,
            string value,
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
