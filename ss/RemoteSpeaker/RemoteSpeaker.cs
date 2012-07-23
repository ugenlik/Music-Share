using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using IrrKlang;

namespace SpeakerShare
{
    public class RemoteSpeaker : MarshalByRefObject, IRemoteSpeaker
    {
        private ISoundEngine soundEngine = new ISoundEngine();
        private Random random = new Random();
        private FileInfo currentFile = null;
        private bool paused;

        public void Upload(byte[] mp3FileData)
        {
            currentFile = new FileInfo(Path.Combine(Path.GetTempPath(), random.Next() + ".mp3"));
            FileStream fs = currentFile.OpenWrite();
            fs.Write(mp3FileData, 0, mp3FileData.Length);
            fs.Close();
        }

        public void Play()
        {
            if (paused)
            {
                soundEngine.SetAllSoundsPaused(false);
            }
            else
            {
                Stop();
                if (currentFile != null)
                {
                    soundEngine.Play2D(currentFile.FullName);
                }
            }
            paused = false;
        }

        public void Pause()
        {
            soundEngine.SetAllSoundsPaused(true);
            paused = true;
        }

        public void Stop()
        {
            soundEngine.RemoveAllSoundSources();
            paused = false;
        }
    }
}
