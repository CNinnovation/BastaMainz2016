using Windows.System.Profile;

namespace TailoredSample.ViewModels
{
    public class MainPageViewModel
    {
        public string Hello => "Hello from the ViewModel";
        public string DeviceFamily => AnalyticsInfo.VersionInfo.DeviceFamily;
    }
}
