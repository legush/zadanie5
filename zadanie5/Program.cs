using System;
using System.Collections.Generic;

namespace zadanie5
{
    class Program
    {
        public class student {
            public string ID;
            public string FIO;
            public string group;
            public string date;
        }

        static List<student> SL = new List<student>();

        static void AddStudent(string ID, string FIO, string group, string date) {
            SL.Add(new student() { ID = ID, FIO = FIO, date = date, group = group });
        }


        static void DelStudent(string ID)
        {
            for (int i = 0; i < SL.Count; i++) {

                if (SL[i].ID == ID)
                    SL.RemoveAt(i);
            }
        }

        static void ChangeStudent(string ID, string FIO, string date, string group)
        {

            for (int i = 0; i < SL.Count; i++) {
                if (SL[i].ID == ID) {
                    SL[i].ID = FIO;
                    SL[i].date = date;
                    SL[i].group = group;
                }
            }

        }

        static void ShowStudent()
        {

            foreach (var a in SL) {
                Console.WriteLine(" " + a.ID + " " + a.FIO + " /" + a.group + " /" + a.date);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            student first = new student();

            AddStudent("1", "Антонов Анотон Антонович", "15.12.2000", "ИСИП");
            AddStudent("2", "Нечаева Мария Дмитриевна", "13.01.2001", "ССА");
            AddStudent("3", "Колчак Анна Степановна", "13.09.2002", "КП");
            AddStudent("4", "Никулин Степан Александрович", "18.07.2000", "ССА");
            AddStudent("5", "Миказ Джо -", "30.12.2002", "ИСИП");
            AddStudent("6", "Ким Сон Гын", "29.02.2001", "ИСИП");
            ShowStudent();
            ChangeStudent("7", "Ник Никита Викторович", "29.10.2001", "ИСИП");
            ShowStudent();
            DelStudent("2");
            ShowStudent();
        }
    }
}