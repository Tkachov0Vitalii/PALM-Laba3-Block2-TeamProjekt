using System;

namespace Laba3Block2
{
    class Variant17
    {
        public static void СonsolOutput(Student student)
        {
            Console.WriteLine("------------------------" +
                "\nПрізвище: {0}\n" +
                "Ім'я: {1}\n" +
                "По батькові: {2}\n" +
                "Стать: {3}\n" +
                "Дата народження: {4}\n" +
                "Оцінка з математики: {5}\n" +
                "Оцінка з фізики: {6}\n" +
                "Оцінка з інформатики: {7}\n" +
                "Стипендія: {8}",
                student.surName, student.firstName, student.patronymic, student.sex, student.dateOfBirth,
                student.mathematicsMark, student.physicsMark, student.informaticsMark, student.scholarship);
        }
        public static int[] MidleMark(Student[] studs)
        {
            int[] MidMark = new int[studs.Length];
            for (int i = 0; i < MidMark.Length; i++)
                MidMark[i] = (Convert(studs[i].mathematicsMark)
                    + Convert(studs[i].physicsMark)
                    + Convert(studs[i].informaticsMark)) / 3;

            return MidMark;
        }

        public static int Convert(char a)
        {
            if (a == '-')
                a = '2';

            int b = a - '0';
            return b;
        }

    }
    }
}