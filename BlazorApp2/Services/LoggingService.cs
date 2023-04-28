using System.Collections.ObjectModel;

namespace BlazorApp2.Services;

public class LoggingService
{
    public ObservableCollection<string> Logs { get; set; } = new();
}
