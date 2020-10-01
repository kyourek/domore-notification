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
        }"
        .Replace(" T ", $" {type} ")
        .Dump();
}