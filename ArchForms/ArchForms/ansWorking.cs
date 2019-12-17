using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Работа с ответами пользователя

namespace ArchForms
{
   public class ansWorking
    {
        public int answer = 0;
        public string username = "";

        public ansWorking(string name)
        {
            username = name;
            try
            {
                File.WriteAllText("dir/name.txt", username);
            }
            catch
            {
                
            }
        }

        // Добавление ответа в объект
        public void Add(int _ans)
        {
            answer = _ans;
        }



        // Очистка для результатов
        private void Clear()
        {
            answer = 0;
        }


    }
}
