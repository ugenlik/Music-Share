using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SpeakerShare
{
    public interface IRemoteSpeaker
    {
        void Upload(byte[] mp3FileData);
        void Play();
        void Pause();
        void Stop();
    }
}
