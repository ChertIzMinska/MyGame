using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
     class Player
    {
        uint count_of_workers { get; set; }
        uint count_of_mine { get; set; }
        uint rang_tool { get; set; }
        uint salary { get; set; }
        uint gold
        {
            get; set;
        }
        void take_gold()
        {
            gold = gold + salary;
        }
        public bool winner()
        {
            Console.Clear();
            Console.WriteLine(gold);
            if(gold+salary>=4294967000)
            {
                Console.WriteLine("Вы выиграли.");
                return true;
            }
            return false;
        }
        public void action()
        {
            Console.WriteLine($"Выберите действие:\n1.Улучшить инструменты({ 10 * rang_tool})\n2.Купить шахту({10000 * count_of_mine})\n3.Нанять рабочего({100 * count_of_workers})\n4.Получить прибыль({salary})\n") ;
            int key=0;

            try
            {
                key = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Неверно введенный тип данных ,пожалуйста выберите число.");
                action();
                
            }
           
            switch (key)
            {
                case 1:
                    buy_better_tool();
                    break;
                case 2:
                    buy_mine();
                        break;
                case 3:
                    buy_worker();
                      break;
                case 4:
                    take_gold();
                    break;
                default:
                    Console.WriteLine("Ошибка.Нажмите кнопку от 1 до 4\n");
                    action();
                    break;
            }

        }
        void buy_better_tool()
        {
            if (gold < 10 * rang_tool)
            {
                Console.WriteLine("Вы не имеете достаточно денег ,чтоб улучишть ваши инструменты.");
            }
            else if (300 >= rang_tool)
            {
                gold -= 10 * rang_tool;
                rang_tool++;
                salary += 2;
                Console.WriteLine("Вы успешно улучшили ваши инструменты.");
            }
            else
            {
                Console.WriteLine("Вы  уже имеете лучшие инструменты!");
            }
        }
        void buy_mine()
        {
            if(gold<10000*count_of_mine)
            {
                Console.WriteLine("Вы не имеете достаточно денег ,чтоб купить  шахту.");
            }
            else if(300>=count_of_mine)
            {
                gold -= 10000 * count_of_mine;
                count_of_mine++;
                salary += 200;
                Console.WriteLine("Вы успешно купили шахту.");
            }
            else 
            {
                Console.WriteLine("Вы  имеете максимально количество шахт");
            }
        }
        void buy_worker()
        {
            if (gold < 100 * count_of_workers)
            {
                Console.WriteLine("Вы не имеете достаточно денег ,чтоб нанять рабочего.");
            }
            else if (100000 >= count_of_mine)
            {
                gold -= 100 * count_of_mine;
                count_of_mine++;
                salary += 20;
                Console.WriteLine("В вашей компании на одного рабочего больше.");
            }
            else
            {
                Console.WriteLine("Вы  не можете расширить штат рабочих");
            }
        }
        public Player ()
        {
            gold = 0;
            salary = 1;
            rang_tool = 1;
            count_of_mine = 1;
            count_of_workers = 1;
            Console.WriteLine("Blat");
        }

        
        
    }
}
