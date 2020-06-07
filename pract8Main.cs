using System;
using static System.Console;
using static System.Convert;
using System.Collections;
using System.Collections.Generic;
using studentsLib;
/*int ids = ToInt32(ReadLine());
  parametrs.Add(ids);
  string fio = ReadLine();
  parametrs.Add(fio);
  int group = ToInt32(ReadLine());
  parametrs.Add(group);
  int data = ToInt32(ReadLine());
  parametrs.Add(data);*/
namespace pract5
{

    class Program
    {
        
            static void Main(string[] args)
            {
            Class1 L = new Class1();
            int ids = 0;
                int z,zz;
                do
                {
                /*WriteLine("\nВведите: \n 1. Чтобы добавить студента \n 2. Чтобы изменить \n 3. Удалить \n 4. Вывести Ф.И.О. \n " +
                    "5. Вывести информацию по ID \n 6. Возраст выбранного по ID студента\n 7. Студенты 18+, 18-\n 8. Поиск по фамилии\n 9. Фамилия и инициалы");
                */
                WriteLine("Введите: \n1. Показать Информацию о студентах. \n2. Добавить студента. \n3. Удалить студента. \n4. Изменить студента. \n5. Поиск студентов. \n6. Выход");
                    z = ToInt32(ReadLine());
                    WriteLine("\n");
                if (z == 1)
                {
                    WriteLine("Введите: \n1. Вся информация о студентах. \n2. Список студентов с инициалами. \n3. Список студентов старше 18. \n4. Список студентов младше 18.");
                    zz = ToInt32(ReadLine());
                    WriteLine("\n");
                    if (zz == 1)
                    {
                        L.show2();
                    }
                    else if (zz == 2)
                    {
                        L.showallFIO();
                    }
                    else if (zz == 3)
                    {
                        string ss = "a";
                        L.age18(ss);
                    }
                    else if (zz == 4)
                    {
                        string ss = "s";
                        L.age18(ss);
                    }
                }
                    if (z == 2)
                    {
                        //Добавить
                        WriteLine("\nФ.И.О.: ");
                        string fio = ReadLine();
                        WriteLine("Группа: ");
                        int group = ToInt32(ReadLine());
                        WriteLine("Дата рождения дд.мм.гггг: ");
                        string data = ReadLine();
                        L.addstud(ids, fio, group, data);
                        ids++;
                    }
                    else if (z == 4)
                    {
                        //Изменить
                        WriteLine("\nID студента: ");
                        int idsT = ToInt32(ReadLine());
                        WriteLine("Ф.И.О.: ");
                        string fio = ReadLine();
                        WriteLine("Группа: ");
                        int group = ToInt32(ReadLine());
                        WriteLine("Дата рождения дд.мм.гггг: ");
                        string data = ReadLine();
                        L.izmen(idsT, fio, group, data);
                    }
                    else if (z == 3)
                    {
                        //Удалить
                        ids = ToInt32(ReadLine());
                        L.del(ids);
                    }
                   /* else if (z == 4) L.show(); //Показать ФИО*/

                    else if (z == 5)
                    {
                        WriteLine("Введите: \n1. Вся информация студента по его ID. \n2. Возраст студента по ID. \n3. Поиск студента по фамилии. \n4. Инициалы студента по ID.");
                        zz = ToInt32(ReadLine());
                        WriteLine("\n");
                        if (zz == 1)
                        {
                        WriteLine("Введите ID студента");
                        int idss = ToInt32(ReadLine());
                        L.poiskID(idss);
                        }
                        if (zz == 2)
                        {
                        WriteLine("Введите ID студента");
                        int IDage = ToInt32(ReadLine());
                        L.age(IDage);
                        }
                        if (zz == 3)
                        {
                        WriteLine("Введите фамилию студента: ");
                        string sFIO = ReadLine();
                        L.searchFIO(sFIO);
                        }
                        if (zz == 4)
                        {
                        WriteLine("Введите ID студента: ");
                        int IDstud = ToInt32(ReadLine());
                        L.inicfio(IDstud);
                        }
                    }
                    
                    /*else if (z == 7)
                    {
                        WriteLine("Введите 's' инфа по <18лет\nВведите 'a' инфа по >18лет: ");
                        string ss = ReadLine();
                        L.age18(ss);
                    }*/
                    
                    

                } while (z != 6);


            }
    }
   
}
