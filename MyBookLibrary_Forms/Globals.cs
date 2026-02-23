using Microsoft.Win32;
using MyBookLibrary_BusinessLayer;
using System;
using System.Diagnostics;
using System.Drawing;
using ThemeEngineLibrary;

namespace MyBookLibrary_Forms {
  public class Globals {
    public static clsUser CurrentUser { get; set; }

    public static uint color = 0x6750A4;
    public static clsThemeEngine Theme = new clsThemeEngine(color);

    public static string SourceName = "MyBookLibrary";

    public static bool CheckEventSource() {
      if(!EventLog.SourceExists(SourceName)) {
        EventLog.CreateEventSource(SourceName, "Application");
      }

      return true;
    }

    public static void LogInformation(string message, EventLogEntryType type) {
      if(CheckEventSource()) {
        EventLog.WriteEntry(SourceName, message, type);
      }
    }

    public static void LogError(Exception ex) {
      string message = $"Message error: {ex.Message}\n" +
                       $"Inner exception: {ex.InnerException}\n" +
                       $"Stack trace: {ex.StackTrace}\n" +
                       $"Target site: {ex.TargetSite}\n" +
                       $"Source: {ex.Source}\n";

      LogInformation(message, EventLogEntryType.Error);
    }

    public static void UpdateTheme(uint color) {
      Theme.UpdateScheme(color);
      _SaveToColorRegistry(color);
    }

    public static void UpdateTheme(Color color) {
      Theme.UpdateScheme(color);
      uint u = ColorToUint(color);
      _SaveToColorRegistry(u);
    }

    private static bool _SaveToColorRegistry(uint color) {
      string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\MyBookLibrary";
      string n = color.ToString();

      try {
        Registry.SetValue(keyPath, "Theme Color", n, RegistryValueKind.String);

        return true;
      } catch(Exception ex) {
        Console.WriteLine("Error:" + ex.Message);

        return false;
      }
    }

    public static uint ColorToUint(Color color) {
      return (uint)(color.A << 24) | (uint)(color.R << 16) | (uint)(color.G << 8) | (uint)(color.B);
    }
  }
}
