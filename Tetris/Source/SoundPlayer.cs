using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.DirectX.AudioVideoPlayback;

namespace Tetris
{
    public static class SoundPlayer
    {
        public enum Sounds { Hit, Line, Pause, Switch, Select_0, Select_1, Error, GameOver }
        private enum Music { Menu, Background_0, Background_1, Background_2 }
        private static Audio Menu { get; set; }
        private static List<Audio> PlayList { get; set; }
        //звук,соответствующий энаму
        private static Dictionary<Sounds, Audio> SoundsDictionary { get; set; }
        private static int CurrentTrack { get; set; }

        public static void LoadMusic()
        {
            for (Music music = 0; (int)music < 4; music++)
            {
                string path = @"Music\" + music.ToString() + ".ogg";
                if (File.Exists(path))
                {
                    if (music == Music.Menu)
                    {
                        Menu = new Audio(path);
                        Menu.Ending += new EventHandler((sender, e) => { Menu.CurrentPosition = 0; });
                    }
                    else
                    {
                        if (music == Music.Background_0 || music == Music.Background_1 || music == Music.Background_2)
                        {
                            if (PlayList == null)
                            {
                                PlayList = new List<Audio>();
                            }
                            PlayList.Add(new Audio(path));
                            //вешаем событие на переключение по плейлисту
                            PlayList[PlayList.Count - 1].Ending += new EventHandler((sender, e) => { CurrentTrack = (CurrentTrack + 1) % PlayList.Count; PlayBackground(); });
                        }
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
            if (PlayList != null)
            {
                PlayList[CurrentTrack].CurrentPosition = 0;
                PlayList[CurrentTrack].Play();
            }
        }

        public static void StopBackground()
        {
            if (PlayList != null)
            {
                PlayList[CurrentTrack].Stop();
                CurrentTrack = 0;
            }
        }

        public static void PauseBackground()
        {
            if (PlayList != null)
            {
                PlayList[CurrentTrack].Pause();
            }
        }

        public static void ResumeBackground()
        {
            if (PlayList != null)
            {
                PlayList[CurrentTrack].Play();
            }
        } 

        public static bool SoundFinished(Sounds sound)
        {
            return SoundsDictionary.ContainsKey(sound) && !(SoundsDictionary[sound].CurrentPosition == SoundsDictionary[sound].Duration);
        }               
    }
}