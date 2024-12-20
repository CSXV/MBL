using System;
using System.Diagnostics;

namespace MyBookLibrary_BusinessLayer {
  internal class clsEventLogger {
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
  }
}
