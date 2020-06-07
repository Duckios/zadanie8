using System;
using static System.Console;
using static System.Convert;
using System.Collections;
using System.Collections.Generic;

namespace studentsLib
{
    public class Class1
    {

        public class Student
        {
            public int ids;
            public string fio;
            public int group;
            public string data;
        }
        public List<Student> stud = new List<Student>();

        public string funkfio(string ffio)
        {
            string realfio = "";
            for (int i = 0; i < ffio.Length; i++)
            {
                if (ffio[i] != ' ')
                {
                    realfio += ffio[i];
                }
                else break;

            }
            return realfio;
        }

        public string funkinicfio(string finfio)
        {
            string realinfio = "";
            string k1 = "", k2 = "";
            for (int i = 0; i < finfio.Length; i++)
            {
                if (finfio[i] != ' ')
                {
                    realinfio += finfio[i];
                }
                else
                {
                    k1 += finfio[i + 1];
                    i++;
                    for (int j = i; j < finfio.Length; j++)
                    {
                        if (finfio[j] == ' ')
                        {

                            k2 += finfio[j + 1];
                            break;
                        }
                    }
                    break;
                }
            }
            realinfio += " " + k1.ToUpper() + "." + k2.ToUpper() + ".";
            return realinfio;
        }
        public void showallFIO()
        {
            foreach (var i in stud)
            {
                string allf = funkinicfio(i.fio);
                WriteLine(allf + "\n");
            }
        }
        public void addstud(int ids, string fio, int group, string data)
        {
            stud.Add(new Student() { ids = ids, fio = fio, group = group, data = data });
        }
        public void del(int ids)
        {
            for (int i = 0; i < stud.Count; i++)
            {
                if (stud[i].ids == ids) stud.RemoveAt(i);
            }
        }
        public void izmen(int ids, string fio, int group, string data)
        {
            for (int i = 0; i < stud.Count; i++)
            {
                if (stud[i].ids == ids)
                {
                    stud[i].fio = fio;
                    stud[i].group = group;
                    stud[i].data = data;
                }
            }
        }
        public void show()
        {
            foreach (var i in stud)
            {
                WriteLine(i.fio + "\n");
            }
        }
        public void show2()
        {
            foreach (var i in stud)
            {
                WriteLine(i.ids + "\n" + i.fio + "\n" + i.group + "\n" + i.data + "\n");
            }
        }
        public void poiskID(int id)
        {
            WriteLine(stud[id].ids + "\n" + stud[id].fio + "\n" + stud[id].group + "\n" + stud[id].data + "\n");
        }
        public void age(int idi)
        {
            DateTime idage = ToDateTime(stud[idi].data);
            /* Console.WriteLine(thisDay.ToString("d"));*/
            DateTime now = DateTime.Today;
            int age = now.Year - idage.Year;
            if (idage > now.AddYears(-age)) age--;
            WriteLine(age + " - возраст студента.");
        }
        public void age18(string s1)
        {
            foreach (var idi18 in stud)
            {
                DateTime idage = ToDateTime(idi18.data);
                DateTime now = DateTime.Today;
                int age = now.Year - idage.Year;
                if (idage > now.AddYears(-age)) age--;
                if (s1 == "a")
                {
                    if (age >= 18) WriteLine("\n" + idi18.ids + "\n" + idi18.fio + "\n" + idi18.group + "\n" + idi18.data + "\n");
                }
                else if (s1 == "s")
                {
                    if (age < 18) WriteLine("\n" + idi18.ids + "\n" + idi18.fio + "\n" + idi18.group + "\n" + idi18.data + "\n");
                }
            }

        }

        public void searchFIO(string sFIO)
        {
            string tfio = "";
            foreach (var i in stud)
            {
                tfio = funkfio(i.fio);
                if (tfio == sFIO)
                {
                    WriteLine("\n" + i.ids + "\n" + i.fio + "\n" + i.group + "\n" + i.data + "\n");
                }
            }
        }
        public void inicfio(int IDstud)
        {
            WriteLine("\n" + funkinicfio(stud[IDstud].fio));
        }

    }
    }
