using NUnit.Framework;

namespace Domore.Notification {
    public partial class NotifierTest {
        [Test]
        public void Change_byte_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = (byte)0;
            Subject.Change(ref field, (byte)1, "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_byte_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = (byte)0;
            Subject.Change(ref field, (byte)0, "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_byte_1_ChangesValue() {
            var field = (byte)0;
            Subject.Change(ref field, (byte)1, "expected");
            Assert.That(field, Is.EqualTo(1));
        }

        [Test]
        public void Change_byte_1_ReturnsFalse() {
            var field = (byte)0;
            var actual = Subject.Change(ref field, (byte)0, "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_byte_1_ReturnsTrue() {
            var field = (byte)0;
            var actual = Subject.Change(ref field, (byte)1, "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_byte_2_RaisesPropertyChanged() {
            var field = (byte)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(ref field, (byte)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_byte_2_DoesNotRaisePropertyChanged() {
            var field = (byte)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(ref field, (byte)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_byte_2_ChangesValue() {
            var field = (byte)0;
            var value = Subject.Change(ref field, (byte)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_byte_2_SetsChangedFalse() {
            var field = (byte)0;
            Subject.Change(ref field, (byte)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_byte_2_SetsChangedTrue() {
            var field = (byte)0;
            Subject.Change(ref field, (byte)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_sbyte_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = (sbyte)0;
            Subject.Change(ref field, (sbyte)1, "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_sbyte_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = (sbyte)0;
            Subject.Change(ref field, (sbyte)0, "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_sbyte_1_ChangesValue() {
            var field = (sbyte)0;
            Subject.Change(ref field, (sbyte)1, "expected");
            Assert.That(field, Is.EqualTo(1));
        }

        [Test]
        public void Change_sbyte_1_ReturnsFalse() {
            var field = (sbyte)0;
            var actual = Subject.Change(ref field, (sbyte)0, "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_sbyte_1_ReturnsTrue() {
            var field = (sbyte)0;
            var actual = Subject.Change(ref field, (sbyte)1, "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_sbyte_2_RaisesPropertyChanged() {
            var field = (sbyte)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(ref field, (sbyte)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_sbyte_2_DoesNotRaisePropertyChanged() {
            var field = (sbyte)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(ref field, (sbyte)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_sbyte_2_ChangesValue() {
            var field = (sbyte)0;
            var value = Subject.Change(ref field, (sbyte)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_sbyte_2_SetsChangedFalse() {
            var field = (sbyte)0;
            Subject.Change(ref field, (sbyte)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_sbyte_2_SetsChangedTrue() {
            var field = (sbyte)0;
            Subject.Change(ref field, (sbyte)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_char_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = (char)0;
            Subject.Change(ref field, (char)1, "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_char_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = (char)0;
            Subject.Change(ref field, (char)0, "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_char_1_ChangesValue() {
            var field = (char)0;
            Subject.Change(ref field, (char)1, "expected");
            Assert.That(field, Is.EqualTo(1));
        }

        [Test]
        public void Change_char_1_ReturnsFalse() {
            var field = (char)0;
            var actual = Subject.Change(ref field, (char)0, "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_char_1_ReturnsTrue() {
            var field = (char)0;
            var actual = Subject.Change(ref field, (char)1, "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_char_2_RaisesPropertyChanged() {
            var field = (char)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(ref field, (char)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_char_2_DoesNotRaisePropertyChanged() {
            var field = (char)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(ref field, (char)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_char_2_ChangesValue() {
            var field = (char)0;
            var value = Subject.Change(ref field, (char)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_char_2_SetsChangedFalse() {
            var field = (char)0;
            Subject.Change(ref field, (char)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_char_2_SetsChangedTrue() {
            var field = (char)0;
            Subject.Change(ref field, (char)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_decimal_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = (decimal)0;
            Subject.Change(ref field, (decimal)1, "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_decimal_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = (decimal)0;
            Subject.Change(ref field, (decimal)0, "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_decimal_1_ChangesValue() {
            var field = (decimal)0;
            Subject.Change(ref field, (decimal)1, "expected");
            Assert.That(field, Is.EqualTo(1));
        }

        [Test]
        public void Change_decimal_1_ReturnsFalse() {
            var field = (decimal)0;
            var actual = Subject.Change(ref field, (decimal)0, "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_decimal_1_ReturnsTrue() {
            var field = (decimal)0;
            var actual = Subject.Change(ref field, (decimal)1, "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_decimal_2_RaisesPropertyChanged() {
            var field = (decimal)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(ref field, (decimal)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_decimal_2_DoesNotRaisePropertyChanged() {
            var field = (decimal)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(ref field, (decimal)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_decimal_2_ChangesValue() {
            var field = (decimal)0;
            var value = Subject.Change(ref field, (decimal)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_decimal_2_SetsChangedFalse() {
            var field = (decimal)0;
            Subject.Change(ref field, (decimal)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_decimal_2_SetsChangedTrue() {
            var field = (decimal)0;
            Subject.Change(ref field, (decimal)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_double_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = (double)0;
            Subject.Change(ref field, (double)1, "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_double_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = (double)0;
            Subject.Change(ref field, (double)0, "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_double_1_ChangesValue() {
            var field = (double)0;
            Subject.Change(ref field, (double)1, "expected");
            Assert.That(field, Is.EqualTo(1));
        }

        [Test]
        public void Change_double_1_ReturnsFalse() {
            var field = (double)0;
            var actual = Subject.Change(ref field, (double)0, "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_double_1_ReturnsTrue() {
            var field = (double)0;
            var actual = Subject.Change(ref field, (double)1, "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_double_2_RaisesPropertyChanged() {
            var field = (double)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(ref field, (double)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_double_2_DoesNotRaisePropertyChanged() {
            var field = (double)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(ref field, (double)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_double_2_ChangesValue() {
            var field = (double)0;
            var value = Subject.Change(ref field, (double)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_double_2_SetsChangedFalse() {
            var field = (double)0;
            Subject.Change(ref field, (double)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_double_2_SetsChangedTrue() {
            var field = (double)0;
            Subject.Change(ref field, (double)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_float_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = (float)0;
            Subject.Change(ref field, (float)1, "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_float_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = (float)0;
            Subject.Change(ref field, (float)0, "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_float_1_ChangesValue() {
            var field = (float)0;
            Subject.Change(ref field, (float)1, "expected");
            Assert.That(field, Is.EqualTo(1));
        }

        [Test]
        public void Change_float_1_ReturnsFalse() {
            var field = (float)0;
            var actual = Subject.Change(ref field, (float)0, "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_float_1_ReturnsTrue() {
            var field = (float)0;
            var actual = Subject.Change(ref field, (float)1, "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_float_2_RaisesPropertyChanged() {
            var field = (float)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(ref field, (float)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_float_2_DoesNotRaisePropertyChanged() {
            var field = (float)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(ref field, (float)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_float_2_ChangesValue() {
            var field = (float)0;
            var value = Subject.Change(ref field, (float)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_float_2_SetsChangedFalse() {
            var field = (float)0;
            Subject.Change(ref field, (float)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_float_2_SetsChangedTrue() {
            var field = (float)0;
            Subject.Change(ref field, (float)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_int_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = (int)0;
            Subject.Change(ref field, (int)1, "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_int_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = (int)0;
            Subject.Change(ref field, (int)0, "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_int_1_ChangesValue() {
            var field = (int)0;
            Subject.Change(ref field, (int)1, "expected");
            Assert.That(field, Is.EqualTo(1));
        }

        [Test]
        public void Change_int_1_ReturnsFalse() {
            var field = (int)0;
            var actual = Subject.Change(ref field, (int)0, "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_int_1_ReturnsTrue() {
            var field = (int)0;
            var actual = Subject.Change(ref field, (int)1, "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_int_2_RaisesPropertyChanged() {
            var field = (int)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(ref field, (int)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_int_2_DoesNotRaisePropertyChanged() {
            var field = (int)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(ref field, (int)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_int_2_ChangesValue() {
            var field = (int)0;
            var value = Subject.Change(ref field, (int)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_int_2_SetsChangedFalse() {
            var field = (int)0;
            Subject.Change(ref field, (int)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_int_2_SetsChangedTrue() {
            var field = (int)0;
            Subject.Change(ref field, (int)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_uint_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = (uint)0;
            Subject.Change(ref field, (uint)1, "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_uint_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = (uint)0;
            Subject.Change(ref field, (uint)0, "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_uint_1_ChangesValue() {
            var field = (uint)0;
            Subject.Change(ref field, (uint)1, "expected");
            Assert.That(field, Is.EqualTo(1));
        }

        [Test]
        public void Change_uint_1_ReturnsFalse() {
            var field = (uint)0;
            var actual = Subject.Change(ref field, (uint)0, "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_uint_1_ReturnsTrue() {
            var field = (uint)0;
            var actual = Subject.Change(ref field, (uint)1, "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_uint_2_RaisesPropertyChanged() {
            var field = (uint)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(ref field, (uint)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_uint_2_DoesNotRaisePropertyChanged() {
            var field = (uint)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(ref field, (uint)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_uint_2_ChangesValue() {
            var field = (uint)0;
            var value = Subject.Change(ref field, (uint)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_uint_2_SetsChangedFalse() {
            var field = (uint)0;
            Subject.Change(ref field, (uint)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_uint_2_SetsChangedTrue() {
            var field = (uint)0;
            Subject.Change(ref field, (uint)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_long_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = (long)0;
            Subject.Change(ref field, (long)1, "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_long_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = (long)0;
            Subject.Change(ref field, (long)0, "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_long_1_ChangesValue() {
            var field = (long)0;
            Subject.Change(ref field, (long)1, "expected");
            Assert.That(field, Is.EqualTo(1));
        }

        [Test]
        public void Change_long_1_ReturnsFalse() {
            var field = (long)0;
            var actual = Subject.Change(ref field, (long)0, "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_long_1_ReturnsTrue() {
            var field = (long)0;
            var actual = Subject.Change(ref field, (long)1, "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_long_2_RaisesPropertyChanged() {
            var field = (long)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(ref field, (long)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_long_2_DoesNotRaisePropertyChanged() {
            var field = (long)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(ref field, (long)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_long_2_ChangesValue() {
            var field = (long)0;
            var value = Subject.Change(ref field, (long)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_long_2_SetsChangedFalse() {
            var field = (long)0;
            Subject.Change(ref field, (long)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_long_2_SetsChangedTrue() {
            var field = (long)0;
            Subject.Change(ref field, (long)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_ulong_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = (ulong)0;
            Subject.Change(ref field, (ulong)1, "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_ulong_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = (ulong)0;
            Subject.Change(ref field, (ulong)0, "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_ulong_1_ChangesValue() {
            var field = (ulong)0;
            Subject.Change(ref field, (ulong)1, "expected");
            Assert.That(field, Is.EqualTo(1));
        }

        [Test]
        public void Change_ulong_1_ReturnsFalse() {
            var field = (ulong)0;
            var actual = Subject.Change(ref field, (ulong)0, "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_ulong_1_ReturnsTrue() {
            var field = (ulong)0;
            var actual = Subject.Change(ref field, (ulong)1, "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_ulong_2_RaisesPropertyChanged() {
            var field = (ulong)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(ref field, (ulong)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_ulong_2_DoesNotRaisePropertyChanged() {
            var field = (ulong)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(ref field, (ulong)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_ulong_2_ChangesValue() {
            var field = (ulong)0;
            var value = Subject.Change(ref field, (ulong)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_ulong_2_SetsChangedFalse() {
            var field = (ulong)0;
            Subject.Change(ref field, (ulong)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_ulong_2_SetsChangedTrue() {
            var field = (ulong)0;
            Subject.Change(ref field, (ulong)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_short_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = (short)0;
            Subject.Change(ref field, (short)1, "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_short_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = (short)0;
            Subject.Change(ref field, (short)0, "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_short_1_ChangesValue() {
            var field = (short)0;
            Subject.Change(ref field, (short)1, "expected");
            Assert.That(field, Is.EqualTo(1));
        }

        [Test]
        public void Change_short_1_ReturnsFalse() {
            var field = (short)0;
            var actual = Subject.Change(ref field, (short)0, "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_short_1_ReturnsTrue() {
            var field = (short)0;
            var actual = Subject.Change(ref field, (short)1, "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_short_2_RaisesPropertyChanged() {
            var field = (short)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(ref field, (short)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_short_2_DoesNotRaisePropertyChanged() {
            var field = (short)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(ref field, (short)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_short_2_ChangesValue() {
            var field = (short)0;
            var value = Subject.Change(ref field, (short)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_short_2_SetsChangedFalse() {
            var field = (short)0;
            Subject.Change(ref field, (short)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_short_2_SetsChangedTrue() {
            var field = (short)0;
            Subject.Change(ref field, (short)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_ushort_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = (ushort)0;
            Subject.Change(ref field, (ushort)1, "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_ushort_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = (ushort)0;
            Subject.Change(ref field, (ushort)0, "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_ushort_1_ChangesValue() {
            var field = (ushort)0;
            Subject.Change(ref field, (ushort)1, "expected");
            Assert.That(field, Is.EqualTo(1));
        }

        [Test]
        public void Change_ushort_1_ReturnsFalse() {
            var field = (ushort)0;
            var actual = Subject.Change(ref field, (ushort)0, "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_ushort_1_ReturnsTrue() {
            var field = (ushort)0;
            var actual = Subject.Change(ref field, (ushort)1, "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_ushort_2_RaisesPropertyChanged() {
            var field = (ushort)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(ref field, (ushort)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_ushort_2_DoesNotRaisePropertyChanged() {
            var field = (ushort)0;
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(ref field, (ushort)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_ushort_2_ChangesValue() {
            var field = (ushort)0;
            var value = Subject.Change(ref field, (ushort)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_ushort_2_SetsChangedFalse() {
            var field = (ushort)0;
            Subject.Change(ref field, (ushort)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_ushort_2_SetsChangedTrue() {
            var field = (ushort)0;
            Subject.Change(ref field, (ushort)1, out var changed, "");
            Assert.That(changed, Is.True);
        }
    }
}
