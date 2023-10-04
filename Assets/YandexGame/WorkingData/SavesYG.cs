using UnityEngine;
using System.Collections.Generic;
using System.Web;
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        // Тестовые сохранения для демо сцены
        // Можно удалить этот код, но тогда удалите и демо (папка Example)
        public int money = 1;                       // Можно задать полям значения по умолчанию
        public string newPlayerName = "Hel!";
        public bool[] openLevels = new bool[3];

        public Dictionary<string, ShopData> stores;

        public SavesYG()
        {
            // Допустим, задать значения по умолчанию для отдельных элементов массива
            stores = new Dictionary<string, ShopData>();
            openLevels[1] = true;
        }
    }
}
