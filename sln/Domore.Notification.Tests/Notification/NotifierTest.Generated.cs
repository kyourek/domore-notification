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
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((byte)0, (byte)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_byte_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((byte)0, (byte)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_byte_2_ChangesValue() {
            var value = Subject.Change((byte)0, (byte)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_byte_2_SetsChangedFalse() {
            Subject.Change((byte)0, (byte)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_byte_2_SetsChangedTrue() {
            Subject.Change((byte)0, (byte)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_byte_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((byte)0, (byte)1, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_byte_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((byte)0, (byte)0, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_byte_3_ChangesValue() {
            var value = Subject.Change((byte)0, (byte)1, "expected");
            Assert.That(value, Is.EqualTo(1));
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
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((sbyte)0, (sbyte)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_sbyte_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((sbyte)0, (sbyte)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_sbyte_2_ChangesValue() {
            var value = Subject.Change((sbyte)0, (sbyte)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_sbyte_2_SetsChangedFalse() {
            Subject.Change((sbyte)0, (sbyte)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_sbyte_2_SetsChangedTrue() {
            Subject.Change((sbyte)0, (sbyte)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_sbyte_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((sbyte)0, (sbyte)1, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_sbyte_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((sbyte)0, (sbyte)0, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_sbyte_3_ChangesValue() {
            var value = Subject.Change((sbyte)0, (sbyte)1, "expected");
            Assert.That(value, Is.EqualTo(1));
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
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((char)0, (char)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_char_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((char)0, (char)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_char_2_ChangesValue() {
            var value = Subject.Change((char)0, (char)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_char_2_SetsChangedFalse() {
            Subject.Change((char)0, (char)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_char_2_SetsChangedTrue() {
            Subject.Change((char)0, (char)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_char_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((char)0, (char)1, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_char_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((char)0, (char)0, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_char_3_ChangesValue() {
            var value = Subject.Change((char)0, (char)1, "expected");
            Assert.That(value, Is.EqualTo(1));
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
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((decimal)0, (decimal)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_decimal_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((decimal)0, (decimal)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_decimal_2_ChangesValue() {
            var value = Subject.Change((decimal)0, (decimal)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_decimal_2_SetsChangedFalse() {
            Subject.Change((decimal)0, (decimal)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_decimal_2_SetsChangedTrue() {
            Subject.Change((decimal)0, (decimal)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_decimal_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((decimal)0, (decimal)1, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_decimal_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((decimal)0, (decimal)0, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_decimal_3_ChangesValue() {
            var value = Subject.Change((decimal)0, (decimal)1, "expected");
            Assert.That(value, Is.EqualTo(1));
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
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((double)0, (double)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_double_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((double)0, (double)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_double_2_ChangesValue() {
            var value = Subject.Change((double)0, (double)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_double_2_SetsChangedFalse() {
            Subject.Change((double)0, (double)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_double_2_SetsChangedTrue() {
            Subject.Change((double)0, (double)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_double_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((double)0, (double)1, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_double_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((double)0, (double)0, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_double_3_ChangesValue() {
            var value = Subject.Change((double)0, (double)1, "expected");
            Assert.That(value, Is.EqualTo(1));
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
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((float)0, (float)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_float_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((float)0, (float)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_float_2_ChangesValue() {
            var value = Subject.Change((float)0, (float)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_float_2_SetsChangedFalse() {
            Subject.Change((float)0, (float)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_float_2_SetsChangedTrue() {
            Subject.Change((float)0, (float)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_float_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((float)0, (float)1, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_float_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((float)0, (float)0, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_float_3_ChangesValue() {
            var value = Subject.Change((float)0, (float)1, "expected");
            Assert.That(value, Is.EqualTo(1));
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
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((int)0, (int)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_int_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((int)0, (int)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_int_2_ChangesValue() {
            var value = Subject.Change((int)0, (int)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_int_2_SetsChangedFalse() {
            Subject.Change((int)0, (int)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_int_2_SetsChangedTrue() {
            Subject.Change((int)0, (int)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_int_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((int)0, (int)1, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_int_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((int)0, (int)0, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_int_3_ChangesValue() {
            var value = Subject.Change((int)0, (int)1, "expected");
            Assert.That(value, Is.EqualTo(1));
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
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((uint)0, (uint)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_uint_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((uint)0, (uint)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_uint_2_ChangesValue() {
            var value = Subject.Change((uint)0, (uint)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_uint_2_SetsChangedFalse() {
            Subject.Change((uint)0, (uint)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_uint_2_SetsChangedTrue() {
            Subject.Change((uint)0, (uint)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_uint_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((uint)0, (uint)1, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_uint_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((uint)0, (uint)0, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_uint_3_ChangesValue() {
            var value = Subject.Change((uint)0, (uint)1, "expected");
            Assert.That(value, Is.EqualTo(1));
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
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((long)0, (long)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_long_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((long)0, (long)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_long_2_ChangesValue() {
            var value = Subject.Change((long)0, (long)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_long_2_SetsChangedFalse() {
            Subject.Change((long)0, (long)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_long_2_SetsChangedTrue() {
            Subject.Change((long)0, (long)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_long_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((long)0, (long)1, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_long_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((long)0, (long)0, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_long_3_ChangesValue() {
            var value = Subject.Change((long)0, (long)1, "expected");
            Assert.That(value, Is.EqualTo(1));
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
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((ulong)0, (ulong)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_ulong_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((ulong)0, (ulong)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_ulong_2_ChangesValue() {
            var value = Subject.Change((ulong)0, (ulong)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_ulong_2_SetsChangedFalse() {
            Subject.Change((ulong)0, (ulong)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_ulong_2_SetsChangedTrue() {
            Subject.Change((ulong)0, (ulong)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_ulong_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((ulong)0, (ulong)1, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_ulong_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((ulong)0, (ulong)0, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_ulong_3_ChangesValue() {
            var value = Subject.Change((ulong)0, (ulong)1, "expected");
            Assert.That(value, Is.EqualTo(1));
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
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((short)0, (short)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_short_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((short)0, (short)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_short_2_ChangesValue() {
            var value = Subject.Change((short)0, (short)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_short_2_SetsChangedFalse() {
            Subject.Change((short)0, (short)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_short_2_SetsChangedTrue() {
            Subject.Change((short)0, (short)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_short_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((short)0, (short)1, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_short_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((short)0, (short)0, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_short_3_ChangesValue() {
            var value = Subject.Change((short)0, (short)1, "expected");
            Assert.That(value, Is.EqualTo(1));
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
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((ushort)0, (ushort)1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_ushort_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((ushort)0, (ushort)0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_ushort_2_ChangesValue() {
            var value = Subject.Change((ushort)0, (ushort)1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_ushort_2_SetsChangedFalse() {
            Subject.Change((ushort)0, (ushort)0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_ushort_2_SetsChangedTrue() {
            Subject.Change((ushort)0, (ushort)1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_ushort_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change((ushort)0, (ushort)1, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_ushort_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change((ushort)0, (ushort)0, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_ushort_3_ChangesValue() {
            var value = Subject.Change((ushort)0, (ushort)1, "expected");
            Assert.That(value, Is.EqualTo(1));
        }
    }
}


