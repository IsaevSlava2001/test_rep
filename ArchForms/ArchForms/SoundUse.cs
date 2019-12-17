using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sound;

// Хранение и вызов звуковых файлов

namespace SoundUse
{

    public class Use{
        private string dir = "sounds/";

        public void Battle()
        {
            SoundSystem sound = new SoundSystem("battleTheme.wav");
            sound.Play(true);

        }

        public void Menu()
        {
            SoundSystem sound = new SoundSystem("MainMenuTheme.wav");
            sound.Play(true);
        }

        public void Main() 
        {
            SoundSystem sound = new SoundSystem("MainTheme.wav");
            sound.Play(true);
        }

    }



}
