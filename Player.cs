using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    interface IPlayable
    {
        void Play();
    }
    class MusicPlayer:IPlayable
    {
        public void Play()
        {
            Console.WriteLine("playing music");
        }
    }
    class VideoPlayer:IPlayable
    {
        public void Play()
        {
            Console.WriteLine("video playing");
        }
    }
}
