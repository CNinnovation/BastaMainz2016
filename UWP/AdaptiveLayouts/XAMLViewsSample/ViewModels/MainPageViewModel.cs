using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.Profile;

namespace XAMLViewsSample.ViewModels
{
    public class MainPageViewModel
    {
        public string Hello => "Hello from the ViewModel";
        public string DeviceFamily => AnalyticsInfo.VersionInfo.DeviceFamily;
    }
}
