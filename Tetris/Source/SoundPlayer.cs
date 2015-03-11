using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.DirectX.AudioVideoPlayback;

namespace Tetris
{
    public static class SoundPlayer
    {
        private const string MenuPath = "Music\\Menu.ogg";

        public enum Sounds { Hit, Line, Pause, Switch, Select_0, Select_1, Error, GameOver }
        private static Audio Menu { get; set; }
        private static List<Audio> GamePlaylist { get; set; }
        //звук,соответствующий энаму
        private static Dictionary<Sounds, Audio> SoundsDictionary { get; set; }
        private static int CurrentTrack { get; set; }

        public static void LoadMusic()
        {
            foreach (string music in Directory.GetFiles(@"Music", "*.ogg"))
            {
                if (File.Exists(music))
                {
                    if (music.Equals(MenuPath))
                    {
                        Menu = new Audio(music);
                        Menu.Ending += new EventHandler((sender, e) => { Menu.CurrentPosition = 0; });
                    }
                    else
                    {
                        if (GamePlaylist == null)
                        {
                            GamePlaylist = new List<Audio>();
                        }
                        GamePlaylist.Add(new Audio(music));
                        //Событие на переключение на следующий трек плейлиста по завершении предыдущего
                        GamePlaylist[GamePlaylist.Count - 1].Ending += new EventHandler((sender, e) => { CurrentTrack = (CurrentTrack + 1) % GamePlaylist.Count; PlayBackground(); });
                    }
                }
            }
        }

        public static void LoadSounds()
        {
            for (Sounds sound = 0; (int)sound < 8; sound++)
            {
                string path = @"Sounds\" + sound.ToString() + ".wav";
                if (File.Exists(path))
                {
                    if (SoundsDictionary == null)
                    {
                        SoundsDictionary = new Dictionary<Sounds, Audio>();
                    }
                    SoundsDictionary.Add(sound, new Audio(path));
                }
            }
        }

        public static void PlaySound(Sounds sound)
        {
            if (SoundsDictionary != null && SoundsDictionary.ContainsKey(sound))
            {
                SoundsDictionary[sound].CurrentPosition = 0;
                SoundsDictionary[sound].Play();
            }
        }

        public static void PlayMenu()
        {
            if (Menu != null)
            {
                Menu.Play();
            }
        }

        public static void StopMenu()
        {
            if (Menu != null)
            {
                Menu.Stop();
            }
        }

        public static void PlayBackground()
        {
            if (GamePlaylist != null)
            {
                GamePlaylist[CurrentTrack].CurrentPosition = 0;
                GamePlaylist[CurrentTrack].Play();
            }
        }

        public static void StopBackground()
        {
            if (GamePlaylist != null)
            {
                GamePlaylist[CurrentTrack].Stop();
                CurrentTrack = 0;
            }
        }

        public static void PauseBackground()
        {
            if (GamePlaylist != null)
            {
                GamePlaylist[CurrentTrack].Pause();
            }
        }

        public static void ResumeBackground()
        {
            if (GamePlaylist != null)
            {
                GamePlaylist[CurrentTrack].Play();
            }
        }

        public static bool SoundFinished(Sounds sound)
        {
            return SoundsDictionary.ContainsKey(sound) && !(SoundsDictionary[sound].CurrentPosition == SoundsDictionary[sound].Duration);
        }
    }
}