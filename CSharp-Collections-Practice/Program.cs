using System;
using System.Collections.Generic;
using ClassLibrary;
namespace CSharp_Collections_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>();
            string strNo;
            int no;
            string answer = "";
            string fullname = "";
            string examName = "";
            int examPoint;
            string strPoint;
            string filterExam;
            string strRemove;
            do
            {
                  Console.WriteLine("1. Telebe elave et\n"+
                                    "2.Telebeye imtahan elave et\n"+
                                    "3.Telebenin bir imtahan balına bax\n"+
                                    "4.Telebenin bütün imtahanlarını göster\n"+
                                    "5.Telebenin imtahan ortalamasını göster\n"+
                                    "6.Telebeden imtahan sil\n"+
                                    "0.Proqramı bitir");

                answer = Console.ReadLine();
                if (answer=="1")
                {
                    do
                    {
                        Console.WriteLine("telebenin adini daxil edin: ");
                        fullname = Console.ReadLine();
                    } while (String.IsNullOrWhiteSpace(fullname));

                    Student student = new Student();
                    student.Fullname = fullname;
                    students.Add(student);
                    
                }
                else if (answer == "2")
                {
                    do
                    {
                        Console.WriteLine("telebenin nomresini daxil edin: ");
                        strNo = Console.ReadLine();
                    } while (!int.TryParse(strNo,out no));
                    do
                    {
                        Console.WriteLine("telebe ucun imtahan adini daxil edin: ");
                        examName = Console.ReadLine();
                    } while (String.IsNullOrWhiteSpace(examName));

                    do
                    {
                        Console.WriteLine("telebenin imtahan balini daxil edin: ");
                        strPoint = Console.ReadLine();
                    } while (!int.TryParse(strPoint, out examPoint));

                    foreach (var item in students)
                    {
                        if (item.No==no)
                        {
                            item.AddExam(examName, examPoint);
                        }
                    };
                }
                else if(answer == "3")
                {
                    do
                    {
                        Console.WriteLine("telebenin nomresini daxil edin: ");
                        strNo = Console.ReadLine();
                    } while (!int.TryParse(strNo, out no));
                    do
                    {
                        Console.WriteLine("telebenin baxmaq istediyiniz imtahanin adini yazin: ");
                        filterExam = Console.ReadLine();
                    } while (String.IsNullOrEmpty(filterExam));
                    foreach (var item in students)
                    {
                        if (item.No==no)
                        {
                            Console.WriteLine(item.GetExamResult(examName)); ;
                        }
                    };
                }
                else if( answer == "4")
                {
                    do
                    {
                        Console.WriteLine("telebenin nomresini daxil edin: ");
                        strNo = Console.ReadLine();
                    } while (!int.TryParse(strNo, out no));
                    foreach (var item in students)
                    {
                        if (item.No==no)
                        {
                            foreach (var exam in item.Exams)
                            {
                                Console.WriteLine($"imtahan adi: {exam.Key} | imtahan neticesi: {exam.Value}");
                            };
                        }
                        
                    }
                }
                else if (answer == "5")
                {
                    do
                    {
                        Console.WriteLine("telebenin nomresini daxil edin: ");
                        strNo = Console.ReadLine();
                    } while (!int.TryParse(strNo, out no));
                    foreach (var item in students)
                    {
                        if (item.No==no)
                        {
                            Console.WriteLine(item.GetExamAvg());
                        }
                    }
                }
                else if (answer == "6")
                {
                    do
                    {
                        Console.WriteLine("telebenin nomresini daxil edin: ");
                        strNo = Console.ReadLine();
                    } while (!int.TryParse(strNo, out no));
                    do
                    {
                        Console.WriteLine("silmek istediyiniz imtahanin adini yazin: ");
                        strRemove = Console.ReadLine();
                    } while (String.IsNullOrEmpty(strRemove));
                    foreach (var item in students)
                    {
                        if (item.No==no)
                        {
                            item.Exams.Remove(strRemove);
                        }
                    }
                }
            } while (answer!="0");
        }
    }
}
