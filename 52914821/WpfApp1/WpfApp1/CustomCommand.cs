using System.Windows.Input;

namespace WpfApp1
{
    public static class CustomCommand
    {
        public static RoutedUICommand Save { get; } = new RoutedUICommand(
            text: "Save",
            name: "Save",
            ownerType: typeof(CustomCommand),
            inputGestures: new InputGestureCollection()
            {
                new KeyGesture( Key.F2 ),
            });
        public static RoutedUICommand Test { get; } = new RoutedUICommand(
            text: "Test",
            name: "Test",
            ownerType: typeof(CustomCommand),
            inputGestures: new InputGestureCollection()
            {
                new KeyGesture( Key.F3 ),
            });
    }
}
