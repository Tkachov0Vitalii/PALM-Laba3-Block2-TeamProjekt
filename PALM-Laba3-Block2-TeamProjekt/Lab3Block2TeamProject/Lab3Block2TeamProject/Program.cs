using System;
using System.IO;

namespace Laba3Block2
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Student[] studs = ReadData("data.txt");
            runMenu(studs);
        }

        static Student[] ReadData(string fileName)
        {
            string[] dataFromFile = File.ReadAllLines(fileName);
            Student[] resStud = new Student[dataFromFile.Length];
            for (int i = 0; i < dataFromFile.Length; i++)
            {
                resStud[i] = new Student(dataFromFile[i]);
            }

            return resStud;
        }

        public static void runMenu(Student[] studs)
        {
            Console.WriteLine("Група:\t\tПрізвище:\tІм'я:\t\tВаріант:" +
                              "\nКТ-20\t\tВодянов\t\tСергій\t\t№14" +
                              "\nКТ-20\t\tТкачов\t\tВіталій\t\t№17" +
                              "\nКТ-20\t\tКопійченко\tРостислав\t№2" +
            "\nВведіть номер варіанту який потрібно виконати:");
            int variant = int.Parse(Console.ReadLine());
            if(variant == 14)
            {
                //-----------Водянов-----------------------------------
                for (int i = 0; i < studs.Length; i++)
                    Variant14.СonsolOutput(studs[i], i + 1);

                int[] GPA = Variant14.CulcGPA(studs);

                int generalGPA = Variant14.CulcGeneralGPA(studs, GPA);

                Variant14.ResultVar14(studs, GPA, generalGPA);
                //-----------Водянов-----------------------------------
            }
            else if(variant == 17)
            {
                //-----------Ткачов------------------------------------
                for (int i = 0; i < studs.Length; i++)
                    Variant17.СonsolOutput(studs[i]);

                int[] MidMark = Variant17.MidleMark(studs);

                Variant17.ResultVar17(studs, MidMark);
                //-----------Ткачов------------------------------------
            }
            else if(variant == 2)
            {
                //-----------Копійченко--------------------------------
                for (int i = 0; i < studs.Length; i++)
                    Variant2.СonsolOutput(studs[i]);

                Console.WriteLine("\nСтуденти чоловіки в яких більше двох не зданих заліків:");
                for (int i = 0; i < studs.Length; i++)                
                    Variant2.Audit(studs[i]);                
                //-----------Копійченко--------------------------------
            }
            Console.ReadKey();            
        }
    }
}
