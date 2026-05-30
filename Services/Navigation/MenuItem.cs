namespace DuitTracker.Frontend.Services.Navigation;

public class MenuItem
{
    public string Title { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Href { get; set; } = string.Empty;
    public bool ExactMatch { get; set; } = false;
}