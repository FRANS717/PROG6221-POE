using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace PROG6221_V1
{
    public static class AudioPlayer
    {
        public static void PlayGreeting(string filePath)
        {
            string audioFilePath = @"C:\Users\shimi\Music\PROG6221 V1\PROG6221 V1\Audio.wav"; // Make sure the file is in the output folder

            // Use the default audio path when a short name or null is provided
            if (string.IsNullOrEmpty(filePath) || filePath == "Audio.wav")
            {
                filePath = audioFilePath;
            }

            // Makes sure the audio file exists first
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Audio file missing: " + filePath);
                return;
            }

            try
            {
                // Loads and plays the greeting
                SoundPlayer player = new SoundPlayer(filePath);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Audio playback failed: " + ex.Message);
            }
        }
    }
}