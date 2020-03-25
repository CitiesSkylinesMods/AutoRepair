namespace AutoRepair.Util {
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using UnityEngine;
    using UnityEngine.SceneManagement;

    /// <summary>
    /// A simple logging class.
    ///
    /// When mod activates, it creates a log file in same location as `output_log.txt`.
    /// Mac users: It will be in the Cities app contents.
    /// </summary>
    public class Log {

        /// <summary>
        /// File name for log file.
        /// </summary>
        public static readonly string LogFileName = $"{typeof(Log).Assembly.GetName().Name}.log";

        /// <summary>
        /// Full path and file name of log file.
        /// </summary>
        public static readonly string LogFilePath = Path.Combine(Application.dataPath, LogFileName);

        /// <summary>
        /// Stopwatch used if <see cref="ShowTimestamp"/> is <c>true</c>.
        /// </summary>
        private static readonly Stopwatch Timestamp = Stopwatch.StartNew();

        /// <summary>
        /// Records last logged entry so we can despam.
        /// </summary>
        private static string lastMessage = string.Empty;

        /// <summary>
        /// Number of repetitions of last entry.
        /// </summary>
        private static ulong lastMessageCount = 0;

        /// <summary>
        /// Initializes static members of the <see cref="Log"/> class.
        /// Resets log file on startup.
        /// </summary>
        static Log() {
            try {
                if (File.Exists(LogFilePath)) {
                    string scene = SceneManager.GetActiveScene().name;

                    if (scene == "Startup" || scene == "IntroScreen") {
                        File.Delete(LogFilePath);
                    } else if (scene == "Game") {
                        Info($"\n--- HOT RELOAD DETECTED ({scene}) ---\n");
                    } else {
                        Info($"\n--- POSSIBLE HOT RELOAD DETECTED ({scene}) ---\n");
                    }
                }

                AssemblyName mod = typeof(Log).Assembly.GetName();
                Info($"\n{mod.Name} v{mod.Version.ToString()}\n", true);
            } catch {
                // ignore
            }
        }

        /// <summary>
        /// Log levels. Also output in log file.
        /// </summary>
        private enum LogLevel {
            Debug,
            Info,
            Error,
        }

        /// <summary>
        /// Gets or sets a value indicating whether the log level should be logged.
        /// </summary>
        public static bool ShowLogLevel { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether timestamps should be logged.
        /// </summary>
        public static bool ShowTimestamp { get; set; } = false;

        /// <summary>
        /// Logs debug trace, only in <c>DEBUG</c> builds.
        /// </summary>
        /// 
        /// <param name="message">Log entry text.</param>
        /// <param name="copyToGameLog">If <c>true</c> will copy to the main game log file.</param>
        [Conditional("DEBUG")]
        public static void Debug(string message, bool copyToGameLog = false) {
            LogToFile(message, LogLevel.Debug, copyToGameLog);
        }

        /// <summary>
        /// Logs info message.
        /// </summary>
        /// 
        /// <param name="message">Log entry text.</param>
        /// <param name="copyToGameLog">If <c>true</c> will copy to the main game log file.</param>
        public static void Info(string message, bool copyToGameLog = false) {
            LogToFile(message, LogLevel.Info, copyToGameLog);
        }

        /// <summary>
        /// Logs error message and also outputs a stack trace.
        /// </summary>
        /// 
        /// <param name="message">Log entry text.</param>
        /// <param name="copyToGameLog">If <c>true</c> will copy to the main game log file.</param>
        public static void Error(string message, bool copyToGameLog = true) {
            LogToFile(message, LogLevel.Error, copyToGameLog);
        }

        /// <summary>
        /// Write a message to log file.
        /// </summary>
        /// 
        /// <param name="message">Log entry text.</param>
        /// <param name="level">Logging level. If set to <see cref="LogLevel.Error"/> a stack trace will be appended.</param>
        private static void LogToFile(string message, LogLevel level, bool copyToGameLog = false) {
            try {
                if (message.Equals(lastMessage)) {
                    ++lastMessageCount;
                    return;
                }

                using StreamWriter w = File.AppendText(LogFilePath);

                if (lastMessageCount > 0) {
                    w.WriteLine($"[{lastMessageCount} repeat(s)]");
                }
                lastMessage = message;
                lastMessageCount = 0;

                if (ShowLogLevel) {
                    w.Write("{0, -8}", $"[{level.ToString()}] ");
                }

                if (ShowTimestamp) {
                    w.Write("{0, 15}", Timestamp.ElapsedTicks + " | ");
                }

                w.WriteLine(message);

                if (level == LogLevel.Error) {
                    w.WriteLine(new StackTrace());
                    w.WriteLine();
                }

                if (copyToGameLog) {
                    if (level == LogLevel.Error) {
                        UnityEngine.Debug.LogError(message);
                    } else {
                        UnityEngine.Debug.Log(message);
                    }
                }
            } catch {
                // ignore
            }
        }
    }
}