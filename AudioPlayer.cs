using System;
using System.IO;
using System.Media;

namespace PROG6221_V1
{
    /// <summary>
    /// Handles playing of audio greetings.
    /// </summary>
    public static class AudioPlayer
    {
        /// <summary>
        /// Plays a WAV greeting file if it exists.
        /// </summary>
        /// <param name="filePath">Path to the .wav file.</param>
        public static void PlayGreeting(string filePath)
        {
            ConsoleHelper.WriteColored($"[Audio] Attempting to play: {filePath}\n", ConsoleColor.DarkGray);

            if (Environment.OSVersion.Platform != PlatformID.Win32NT)
            {
                ConsoleHelper.WriteColored("[Audio] Not on Windows – skipping.\n", ConsoleColor.Yellow);
                return;
            }

            if (!File.Exists(filePath))
            {
                ConsoleHelper.WriteColored($"[Audio] File NOT found at: {Path.GetFullPath(filePath)}\n", ConsoleColor.Red);
                return;
            }

            ConsoleHelper.WriteColored($"[Audio] File found. Size: {new FileInfo(filePath).Length} bytes\n", ConsoleColor.DarkGray);

            try
            {
                using (SoundPlayer player = new SoundPlayer(filePath))
                {
                    player.Load(); // Try loading first
                    ConsoleHelper.WriteColored("[Audio] Loaded successfully. Playing...\n", ConsoleColor.DarkGray);
                    player.PlaySync();
                    ConsoleHelper.WriteColored("[Audio] Playback finished.\n", ConsoleColor.DarkGray);
                }
            }
            catch (Exception ex)
            {
                ConsoleHelper.WriteColored($"[Audio] Error: {ex.Message}\n", ConsoleColor.Red);
            }
        }
    }
}