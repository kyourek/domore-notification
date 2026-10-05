# Domore.Notification

A small base class for implementing `INotifyPropertyChanged`, `INotifyPropertyChanging`, and `INotifyDataErrorInfo` in view models and other observable objects.

Install the package with `dotnet add package Domore.Notification`.

## Raise change events

Implement `INotifyPropertyChanged` in one line per property. `Change` only raises events when the value actually changes, gets the property name for you from `[CallerMemberName]`, and notifies dependent properties along with it.

```csharp
using Domore.Notification;

public sealed class Person : Notifier {
    public string FirstName {
        get => _FirstName;
        set => Change(ref _FirstName, value, nameof(FirstName), nameof(FullName));
    }
    private string _FirstName;

    public int Age {
        get => _Age;
        set => Change(ref _Age, value);
    }
    private int _Age;

    public string FullName => $"{FirstName}".Trim();
}
```

It also raises `PropertyChanging`, has overloads for the built-in value types that avoid boxing, can suppress events during batch updates or veto changes, and offers `Notifier.WithErrorInfo` for `INotifyDataErrorInfo` validation.

---

## License

[MIT](LICENSE) © Ken Yourek
