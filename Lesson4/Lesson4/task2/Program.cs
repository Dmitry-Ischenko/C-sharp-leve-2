﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Выполнил Ищенко Дмитрий
            //2.Дана коллекция List<T>, требуется подсчитать, сколько раз каждый элемент встречается в данной коллекции:
            //а) для целых чисел;
            //б) *для обобщенной коллекции;
            //в) *используя Linq.
            Random rand = new Random();
            //a)
            List<int> a = new List<int>();
            int count = rand.Next(10, 100);
            Console.WriteLine("Дана коллекция целых чисел:");
            for (int i = 0; i < count; i++)
            {
                a.Add(rand.Next(0,10));
                Console.WriteLine(a[a.Count-1]);
            }
            Console.WriteLine("---------------------------\n из них ");
            Dictionary<int, int> countElement = new Dictionary<int, int>();
            foreach (int res in a)
            {
                if(countElement.ContainsKey(res))
                {
                    countElement[res]++;
                } else
                {
                    countElement.Add(res,1);
                }
            }
            foreach (var print in countElement)
            {
                Console.WriteLine($"Элементов [{print.Key}] встреченно {{{print.Value}}} раз");
            }
            Console.ReadKey();
            Console.Clear();
            //b)
            Console.WriteLine("б) *для обобщенной коллекции");
            List<MyClass> b = new List<MyClass>();
            count = rand.Next(10, 100);
            #region Last/First name and group
            string[] lastName = {
                "Смирнов","Орехов","Денисов","Белоусов","Авдеев","Лазарев","Горшков","Кузьмин",
                "Иванов","Ефремов","Громов","Федотов","Зыков","Медведев","Чернов","Кудрявцев",
                "Кузнецов","Исаев","Фомин","Дорофеев","Бирюков","Ершов","Овчинников","Баранов",
                "Соколов","Евдокимов","Давыдов","Егоров","Шарапов","Никитин","Селезнёв","Куликов",
                "Попов","Калашников","Мельников","Матвеев","Никонов","Соболев","Панфилов","Алексеев",
                "Лебедев","Кабанов","Щербаков","Бобров","Щукин","Рябов","Копылов","Степанов",
                "Козлов","Носков","Блинов","Дмитриев","Дьячков","Поляков","Михеев","Яковлев",
                "Новиков","Юдин","Колесников","Калинин","Одинцов","Цветков","Галкин","Сорокин",
                "Морозов","Кулагин","Карпов","Анисимов","Сазонов","Данилов","Назаров","Сергеев",
                "Петров","Лапин","Афанасьев","Петухов","Якушев","Жуков","Лобанов","Романов",
                "Волков","Прохоров","Власов","Антонов","Красильников","Фролов","Лукин","Захаров",
                "Соловьёв","Нестеров","Маслов","Тимофеев","Гордеев","Журавлёв","Беляков","Борисов",
                "Васильев","Харитонов","Исаков","Никифоров","Самойлов","Николаев","Потапов","Королёв",
                "Зайцев","Агафонов","Тихонов","Веселов","Князев","Крылов","Некрасов","Герасимов",
                "Павлов","Муравьёв","Аксёнов","Филиппов","Беспалов","Максимов","Хохлов","Пономарёв",
                "Семёнов","Ларионов","Гаврилов","Марков","Уваров","Сидоров","Жданов","Григорьев",
                "Голубев","Федосеев","Родионов","Большаков","Шашков","Осипов","Ситников",
                "Виноградов","Зимин","Котов","Суханов","Наумов","Сысоев","Симонов",
                "Богданов","Пахомов","Горбунов","Миронов","Шилов","Фомичёв","Мишин",
                "Воробьёв","Шубин","Кудряшов","Ширяев","Воронцов","Русаков","Фадеев",
                "Фёдоров","Игнатов","Быков","Александров","Ермаков","Стрелков","Комиссаров",
                "Михайлов","Филатов","Зуев","Коновалов","Дроздов","Гущин","Мамонтов",
                "Беляев","Крюков","Третьяков","Шестаков","Игнатьев","Тетерин","Носов",
                "Тарасов","Рогов","Савельев","Казаков","Савин","Колобов","Гуляев",
                "Белов","Кулаков","Панов","Ефимов","Логинов","Субботин","Шаров",
                "Комаров","Терентьев","Рыбаков","Бобылёв","Сафонов","Фокин","Устинов",
                "Орлов","Молчанов","Суворов","Доронин","Капустин","Блохин","Вишняков",
                "Киселёв","Владимиров","Абрамов","Белозёров","Кириллов","Селиверстов","Евсеев",
                "Макаров","Артемьев","Воронов","Рожков","Моисеев","Пестов","Лаврентьев",
                "Андреев","Гурьев","Мухин","Самсонов","Елисеев","Кондратьев","Брагин",
                "Ковалёв","Зиновьев","Архипов","Мясников","Кошелев","Силин","Константинов",
                "Ильин","Гришин","Трофимов","Лихачёв","Костин","Меркушев","Корнилов",
                "Гусев","Кононов","Мартынов","Буров","Горбачёв","Лыткин",
                "Титов","Дементьев","Емельянов","Туров"
            };
            string[] firstName =
            {
                "Алан","Георгий","Константин","Роман",
                "Александр","Герман","Лев","Ростислав",
                "Алексей","Глеб","Леонид","Руслан",
                "Альберт","Гордей","Макар","Рустам",
                "Анатолий","Григорий","Максим","Савва",
                "Андрей","Давид","Марат","Савелий",
                "Антон","Дамир","Марк","Святослав",
                "Арсен","Даниил","Марсель","Семен",
                "Арсений","Демид","Матвей","Сергей",
                "Артем","Демьян","Мирон","Станислав",
                "Артемий","Денис","Мирослав","Степан",
                "Артур","Дмитрий","Михаил","Тамерлан",
                "Богдан","Евгений","Назар","Тимофей",
                "Борис","Егор","Никита","Тимур",
                "Вадим","Елисей","Николай","Тихон",
                "Валентин","Захар","Олег","Федор",
                "Валерий","Иван","Павел","Филипп",
                "Василий","Игнат","Петр","Шамиль",
                "Виктор","Игорь","Платон","Эдуард",
                "Виталий","Илья","Прохор","Эльдар",
                "Владимир","Ильяс","Рамиль","Эмиль",
                "Владислав","Камиль","Ратмир","Эрик",
                "Всеволод","Карим","Ринат","Юрий",
                "Вячеслав","Кирилл","Роберт","Ян",
                "Геннадий","Клим","Родион","Ярослав"
            };
            int[] group =
            {
                210,
                220,
                310,
                401,
                402,
                102,
                101
            };
            #endregion
            Console.WriteLine("Создали свой тип и заполнили его:");
            for (int i = 0; i < count; i++)
            {
                string fname = firstName[rand.Next(0, firstName.Length)];
                string lname = lastName[rand.Next(0, lastName.Length)];
                int nGroup = group[rand.Next(0, group.Length)];
                b.Add(new MyClass(fname,lname,nGroup));
                Console.WriteLine($"{b[b.Count - 1].FirstName} {b[b.Count - 1].LastName} в группе {b[b.Count - 1].Group}");
            }

            countElement.Clear();
            Console.WriteLine("Посчитаем количесвто учащихся в группах");
            foreach (var res in b) {
                if (countElement.ContainsKey(res.Group))
                {
                    countElement[res.Group]++;
                }
                else
                {
                    countElement.Add(res.Group, 1);
                }
            }
            foreach(var res in countElement)
            {
                Console.WriteLine($"В группе {res.Key} - {res.Value} учащихся ");
            }
            Console.ReadKey();
            Console.WriteLine("\nв) *используя Linq.");
            Console.WriteLine("Входные данные теже");
            var myLinQRequest = from gp in b
                             group gp by gp.Group
                             into grpC
                             select new { key = grpC.Key, count = grpC.Count() };
            foreach (var res in myLinQRequest)
            {
                Console.WriteLine($"В группе {res.key} - {res.count} учащихся ");
            }
            Console.ReadKey();
        }
        class MyClass
        {
            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            public int Group { get; set; }            
            public MyClass(string _fristname,string _lastname,int _group)
            {
                FirstName = _fristname;
                LastName = _lastname;
                Group = _group;
            }
        }
    }
}
