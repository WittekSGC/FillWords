using System;
using System.Drawing;

namespace FillWords
{
    public enum Mode
    {
        fish,
        plants,
        animals,
        eat
    }
    class properites
    {
        //размер ячейки
        static public int CellSize = 40;

        //цвета
        static public Color EmptyCell = Color.White; // пустой
        static public Color MouseDown = Color.Red; //нажатие мыши
        static public Color CheckStep = Color.FromArgb(192, 255, 255); //ход
        static public Color TrueWord = Color.Green; //правильное слово 

        //пути к папкам
        static public string Animals = "levels/animals/";
        static public string Fishes = "levels/fishes/";
        static public string Eats = "levels/eats/";
        static public string Plants = "levels/plants/";

        //музыка в игре
        static public string Sound = "sounds/backgroundSound.wav";

        //подключение к бд
        static public string DBConnectionString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = {Environment.GetFolderPath(Environment.SpecialFolder.Personal)}\\FillWords\\UserRecords.mdb; Jet OLEDB:Database Password = root;";

        //конфиг файл (последний юзер)
        static public string ConfigFile = "config.bin";

        //время для отображения подсказки
        static public int ShowTipTime = 20000; //20 секунд

        public Mode Mode
        {
            get => default;
            set
            {
            }
        }
    }
}
