namespace BoTechDevelopment.ViewModels.Download;

public class DownloadViewModel
{
    public string RedirectUrl { get; set; } = "";
    public string FilePath { get; set; } = "";
    public bool ShowTimer { get; set; } = false;
    public int TimerDelay { get; set; } = 0;

    public DownloadViewModel(string redirectUrl, string filePath, bool showTimer, int timerDelay)
    {
        RedirectUrl = redirectUrl;
        FilePath = filePath;
        ShowTimer = showTimer;
        TimerDelay = timerDelay;
    }
}