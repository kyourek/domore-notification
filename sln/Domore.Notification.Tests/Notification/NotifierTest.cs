using NUnit.Framework;

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
    }
}
