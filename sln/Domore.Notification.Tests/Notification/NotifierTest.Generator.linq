<Query Kind="Statements" />

var types = new[] {
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
    "ushort"
};

@"using NUnit.Framework;

namespace Domore.Notification {
    public partial class NotifierTest {".Dump();
    
foreach (var type in types) {
    @"[Test]
public void Change_T_1_RaisesPropertyChanged() {
    var actual = """";
    Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

    var field = (T)0;
    Subject.Change(ref field, (T)1, ""expected"");

    Assert.That(actual, Is.EqualTo(""expected""));
}

[Test]
public void Change_T_1_DoesNotRaisePropertyChanged() {
    var actual = """";
    Subject.PropertyChanged += (s, e) => actual = ""fail"";

    var field = (T)0;
    Subject.Change(ref field, (T)0, ""expected"");

    Assert.That(actual, Is.EqualTo(""""));
}

[Test]
public void Change_T_1_ChangesValue() {
    var field = (T)0;
    Subject.Change(ref field, (T)1, ""expected"");
    Assert.That(field, Is.EqualTo(1));
}

[Test]
public void Change_T_1_ReturnsFalse() {
    var field = (T)0;
    var actual = Subject.Change(ref field, (T)0, """");
    Assert.That(actual, Is.False);
}

[Test]
public void Change_T_1_ReturnsTrue() {
    var field = (T)0;
    var actual = Subject.Change(ref field, (T)1, """");
    Assert.That(actual, Is.True);
}

[Test]
public void Change_T_2_RaisesPropertyChanged() {
    var field = (T)0;
    var actual = """";
    Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
    Subject.Change(ref field, (T)1, out _, ""expected"");
    Assert.That(actual, Is.EqualTo(""expected""));
}

[Test]
public void Change_T_2_DoesNotRaisePropertyChanged() {
    var field = (T)0;
    var actual = """";
    Subject.PropertyChanged += (s, e) => actual = ""fail"";
    Subject.Change(ref field, (T)0, out _, ""expected"");
    Assert.That(actual, Is.EqualTo(""""));
}

[Test]
public void Change_T_2_ChangesValue() {
    var field = (T)0;
    var value = Subject.Change(ref field, (T)1, out _, ""expected"");
    Assert.That(value, Is.EqualTo(1));
}

[Test]
public void Change_T_2_SetsChangedFalse() {
    var field = (T)0;
    Subject.Change(ref field, (T)0, out var changed, """");
    Assert.That(changed, Is.False);
}

[Test]
public void Change_T_2_SetsChangedTrue() {
    var field = (T)0;
    Subject.Change(ref field, (T)1, out var changed, """");
    Assert.That(changed, Is.True);
}
"
    .Replace("_T_", $"_{type}_")
    .Replace("(T)", $"({type})")
    .Dump();
}
@"    }
}
".Dump();