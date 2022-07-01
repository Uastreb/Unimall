using System.Text.Json.Nodes;

namespace Shared.Configurations
{
    public class GoogleSheetsConfiguration
    {
        public string ApplicationName { get; set; }
        public string SpeadsheetId { get; set; }
        public GoogleSheetsSettings SettingsJSON { get; set; }
    }
}
