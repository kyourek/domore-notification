using NUnit.Framework;
using System;

namespace Domore.Notification {
    [TestFixture]
    public partial class NotifierTest {
        private Notifier Subject {
            get => _Subject ?? (_Subject = new Notifier());
            set => _Subject = value;
        }
        private Notifier _Subject;

        [SetUp]
        public void SetUp() {
            Subject = null;
        }

        [Test]
        public void Change_T_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = 0;
            Subject.Change<int>(ref field, 1, "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_T_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = 0;
            Subject.Change<int>(ref field, 0, "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_T_1_ChangesValue() {
            var field = 0;
            Subject.Change<int>(ref field, 1, "expected");
            Assert.That(field, Is.EqualTo(1));
        }

        [Test]
        public void Change_T_1_ReturnsFalse() {
            var field = 0;
            var actual = Subject.Change<int>(ref field, 0, "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_T_1_ReturnsTrue() {
            var field = 0;
            var actual = Subject.Change<int>(ref field, 1, "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_T_2_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change<int>(0, 1, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_T_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change<int>(0, 0, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_T_2_ChangesValue() {
            var value = Subject.Change<int>(0, 1, out _, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_T_2_SetsChangedFalse() {
            Subject.Change<int>(0, 0, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_T_2_SetsChangedTrue() {
            Subject.Change<int>(0, 1, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_T_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change<int>(0, 1, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_T_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change<int>(0, 0, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_T_3_ChangesValue() {
            var value = Subject.Change<int>(0, 1, "expected");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void Change_bool_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = false;
            Subject.Change(ref field, true, "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_bool_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = false;
            Subject.Change(ref field, false, "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_bool_1_ChangesValue() {
            var field = false;
            Subject.Change(ref field, true, "expected");
            Assert.That(field, Is.EqualTo(true));
        }

        [Test]
        public void Change_bool_1_ReturnsFalse() {
            var field = false;
            var actual = Subject.Change(ref field, false, "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_bool_1_ReturnsTrue() {
            var field = false;
            var actual = Subject.Change(ref field, true, "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_bool_2_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(false, true, out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_bool_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(false, false, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_bool_2_ChangesValue() {
            var value = Subject.Change(false, true, out _, "expected");
            Assert.That(value, Is.EqualTo(true));
        }

        [Test]
        public void Change_bool_2_SetsChangedFalse() {
            Subject.Change(false, false, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_bool_2_SetsChangedTrue() {
            Subject.Change(false, true, out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_bool_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(false, true, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_bool_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(false, false, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_bool_3_ChangesValue() {
            var value = Subject.Change(false, true, "expected");
            Assert.That(value, Is.EqualTo(true));
        }

        [Test]
        public void Change_string_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = "0";
            Subject.Change(ref field, "1", "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_string_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = "0";
            Subject.Change(ref field, "0", "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_string_1_ChangesValue() {
            var field = "0";
            Subject.Change(ref field, "1", "expected");
            Assert.That(field, Is.EqualTo("1"));
        }

        [Test]
        public void Change_string_1_ReturnsFalse() {
            var field = "0";
            var actual = Subject.Change(ref field, "0", "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_string_1_ReturnsTrue() {
            var field = "0";
            var actual = Subject.Change(ref field, "1", "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_string_2_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change("0", "1", out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_string_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change("0", "0", out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_string_2_ChangesValue() {
            var value = Subject.Change("0", "1", out _, "expected");
            Assert.That(value, Is.EqualTo("1"));
        }

        [Test]
        public void Change_string_2_SetsChangedFalse() {
            Subject.Change("0", "0", out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_string_2_SetsChangedTrue() {
            Subject.Change("0", "1", out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_string_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change("0", "1", "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_string_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change("0", "0", "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_string_3_ChangesValue() {
            var value = Subject.Change("0", "1", "expected");
            Assert.That(value, Is.EqualTo("1"));
        }

        [Test]
        public void Change_TimeSpan_1_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;

            var field = TimeSpan.Zero;
            Subject.Change(ref field, new TimeSpan(1), "expected");

            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_TimeSpan_1_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";

            var field = TimeSpan.Zero;
            Subject.Change(ref field, TimeSpan.Zero, "expected");

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_TimeSpan_1_ChangesValue() {
            var field = TimeSpan.Zero;
            Subject.Change(ref field, new TimeSpan(1), "expected");
            Assert.That(field, Is.EqualTo(new TimeSpan(1)));
        }

        [Test]
        public void Change_TimeSpan_1_ReturnsFalse() {
            var field = TimeSpan.Zero;
            var actual = Subject.Change(ref field, TimeSpan.Zero, "");
            Assert.That(actual, Is.False);
        }

        [Test]
        public void Change_TimeSpan_1_ReturnsTrue() {
            var field = TimeSpan.Zero;
            var actual = Subject.Change(ref field, new TimeSpan(1), "");
            Assert.That(actual, Is.True);
        }

        [Test]
        public void Change_TimeSpan_2_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(TimeSpan.Zero, new TimeSpan(1), out _, "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_TimeSpan_2_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(TimeSpan.Zero, TimeSpan.Zero, out _, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_TimeSpan_2_ChangesValue() {
            var value = Subject.Change(TimeSpan.Zero, new TimeSpan(1), out _, "expected");
            Assert.That(value, Is.EqualTo(new TimeSpan(1)));
        }

        [Test]
        public void Change_TimeSpan_2_SetsChangedFalse() {
            Subject.Change(TimeSpan.Zero, TimeSpan.Zero, out var changed, "");
            Assert.That(changed, Is.False);
        }

        [Test]
        public void Change_TimeSpan_2_SetsChangedTrue() {
            Subject.Change(TimeSpan.Zero, new TimeSpan(1), out var changed, "");
            Assert.That(changed, Is.True);
        }

        [Test]
        public void Change_TimeSpan_3_RaisesPropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = e.PropertyName;
            Subject.Change(TimeSpan.Zero, new TimeSpan(1), "expected");
            Assert.That(actual, Is.EqualTo("expected"));
        }

        [Test]
        public void Change_TimeSpan_3_DoesNotRaisePropertyChanged() {
            var actual = "";
            Subject.PropertyChanged += (s, e) => actual = "fail";
            Subject.Change(TimeSpan.Zero, TimeSpan.Zero, "expected");
            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void Change_TimeSpan_3_ChangesValue() {
            var value = Subject.Change(TimeSpan.Zero, new TimeSpan(1), "expected");
            Assert.That(value, Is.EqualTo(new TimeSpan(1)));
        }
    }
}
