using System;
using System.IO;
using Xamarin.Forms;

namespace AppTest
{
    public class Сотрудники
    {
        public int КодСотрудника { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string Фамилия { get; set; }
        public string Специальность { get; set; }
        public bool Должность { get; set; }
        public string Фото { get; set; }
        public string Бригада { get; set; }
        public int КодБригада { get; set; }
        public string Логин { get; set; }
        public string Пароль { get; set; }
        public ImageSource Изображение { get { return ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(Фото))); } }
    }
}