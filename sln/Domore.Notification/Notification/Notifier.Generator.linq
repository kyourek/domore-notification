<Query Kind="Statements" />

var types = new[] {
    "bool",
    "byte",
    "sbyte",
    "char",
    "decimal",
    "double",
    "float",
    "int",
    "uint",
    "long",
    "ulong",
    "short",
    "ushort",
    "string" };

foreach (var type in types) {
    @"
        protected internal bool Change(
            ref T field,
            T value,
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

        protected internal T Change(
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

        protected internal T Change(
            T oldValue,
            T newValue,
#if NET40
            string propertyName
#else
            [CallerMemberName] string propertyName = null
#endif     
            ) => Change(oldValue, newValue, out _, propertyName);"
        .Replace(" T ", $" {type} ")
        .Dump();
}