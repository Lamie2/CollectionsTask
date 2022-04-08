using System;
using System.Collections.Generic;

namespace CollectionsTask
{
    class Program
    {
        static void Main(string[] args)
        {

             List <Student> students = new List<Student>();
           
            string fullName = "";
            string examName = "";
            int point;
            string strPoint;
            string no = "";
            string answer = "";


            do
            {
                Console.WriteLine($"1. Telebe elave et \n 2.Telebeye imtahan elave et \n " +
                $"3.Telebenin bir imtahan balina bax \n 4.Telebenin butun imtahanlarini goster \n " +
                $"5.Telebenin imtahan ortalamasini goster \n 6.Telebeden imtahan sil \n 0.Programi bitir");
                answer = Console.ReadLine();

                if (answer=="1")
                {
                    do
                    {
                        Console.WriteLine("Telebenin FullName'ni daxil edin :");
                        fullName = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(fullName));
                    Student student = new Student()
                    {
                        FullName = fullName
                    };
                    students.Add(student);
                    

                }
                else if (answer=="2")
                {
                    do
                    {
                        Console.WriteLine("Telebenin nomresini daxil edin : ");
                        no = Console.ReadLine();
                    } while (string.IsNullOrEmpty(no));
                    do
                    {
                        Console.WriteLine("Imtahanin adini daxil edin : ");
                        examName = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(examName));
                    do
                    {
                        Console.WriteLine("Telebenin balini daxil edin : ");
                        strPoint = Console.ReadLine();
                    } while (!int.TryParse(strPoint, out point));
                }
                else if (answer=="3")
                {
                    do
                    {
                        Console.WriteLine("Telebenin nomresini daxil edin : ");
                        no = Console.ReadLine();
                    } while (string.IsNullOrEmpty(no));
                    do
                    {
                        Console.WriteLine("Imtahanin adini daxil edin : ");
                        examName = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(examName));
                    foreach (var item in students)
                    {
                        if (item.No==no)
                            Console.WriteLine(item.GetExamResult(examName));                       
                    }
                }

                else if (answer=="4")
                {
                    do
                    {
                        Console.WriteLine("Telebenin nomresini daxil edin : ");
                        no = Console.ReadLine();
                    } while (string.IsNullOrEmpty(no));
                    foreach (var item in students)
                    {
                        if (item.No==no)
                        {
                            Console.WriteLine($" telebenin imtahanlari ve neticeleri: {item.Exams.Keys} + {item.Exams.Values}");
                        }
                    }
                }
                else if (answer=="5")
                {
                    do
                    {
                        Console.WriteLine("Telebenin nomresini daxil edin : ");
                        no = Console.ReadLine();
                    } while (string.IsNullOrEmpty(no));
                    foreach (var item in students)
                    {
                        if (item.No == no)
                        {
                            Console.WriteLine($" telebenin butun imtahanlardan ortalama bali: {item.GetExamAvg()}");
                        }
                    }
                }
                else if (answer == "6")
                {
                    do
                    {
                        Console.WriteLine("Telebenin nomresini daxil edin : ");
                        no = Console.ReadLine();
                    } while (string.IsNullOrEmpty(no));
                    do
                    {
                        Console.WriteLine("Imtahanin adini daxil edin : ");
                        examName = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(examName));

                    foreach (var item in students)
                    {
                        if (item.No == no)
                        {
                            Dictionary.
                        }
                    }
                }



            } while (answer!="0");
            


            
        }
    }
}
