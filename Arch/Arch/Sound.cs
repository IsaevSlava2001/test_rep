using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sound
{
    public class SoundSystem
    {
        private System.Media.SoundPlayer player;
        private System.Threading.Thread thrd;

        // Конструктор класса
        public SoundSystem(HResource res)
        {

            thrd = new System.Threading.Thread(new System.Threading.ThreadStart(soundthread));
            thrd.IsBackground = true;
            thrd.Start();



        }


        private void soundthread()
        {
            player = new System.Media.SoundPlayer("1.wav");

        }

        // Воспроизвести

        public void Play(bool loop)
        {
            // Если зацикливание включено
            if (loop == true)
            {
                try
                {
                    player.PlayLooping();
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("HLayer3D error!Sound play fail");
                    System.Windows.Forms.Application.Exit();
                }
            }

            // Если зацикливание отключено
            if (loop == false)
            {
                try
                {
                    player.Play();
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("HLayer3D error!Sound play fail");
                    System.Windows.Forms.Application.Exit();
                }
            }

        }

        // Остановить

        public void Stop()
        {

            player.Stop();

        }
    }
}
