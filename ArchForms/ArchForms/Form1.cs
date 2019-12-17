using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sound;
using SoundUse;
using ArchForms;



namespace ArchForms
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            //Use use = new Use();
            //use.Battle();
            InitializeComponent();
            // todo: потоковый читатель имени (провекрка)
            answerLabel.Text = "Ты будешь со мной играть?";
            button1.Text = "Да";
            button2.Text = "Нет";

           // SoundSystem main1 = new SoundSystem("main-theme1.wav");
           // main1.Play(false);
        }

        // Для таймера

        private void timerLabel_Click(object sender, EventArgs e)
        {

        }

        // Для ответа

        private void answerLabel_Click(object sender, EventArgs e)
        {

        }

        // Первый вариант ответа

        private void button1_Click(object sender, EventArgs e)
        {
            ansWorking ans = new ansWorking("Name");
            ans.Add(1);
        }

        // Второй вариант ответа

        private void button2_Click(object sender, EventArgs e)
        {
            ansWorking ans = new ansWorking("Name");
            ans.Add(2);
        }
    }
}
