using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvn_tuan2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Student> student = new List<Student>();

            // a.In ra ds
            student.Add(new Student(1, "Tai", 19));
            student.Add(new Student(2, "Thang", 20));
            student.Add(new Student(3, "An", 16));
            student.Add(new Student(6,"Phu", 18));
            student.Add(new Student(7,"Duong",17));
            Console.WriteLine("===========================");
            Console.WriteLine("a.danh sach hoc sinh");
            foreach (var Student in student)
            {
                {
                    Student.xuat();
                }
            }


            Console.WriteLine("===========================");
            //b. Danh sách học sinh có tuổi từ 15-18
            Console.WriteLine("b. Danh sách học sinh có tuổi từ 15-18");
            var filteredStudents = student.Where(s => s.age >= 15 && s.age <= 18).ToList();

            if (filteredStudents.Any())
            {
                foreach (var s in filteredStudents)
                {
                    s.xuat();
                }
            }
            else
            {
                Console.WriteLine("Không có học sinh nào có tuổi từ 15-18.");
            }



            Console.WriteLine("===========================");
            //c. Học sinh có tên bắt đầu bằng chữ 'A'
            Console.WriteLine("c. Học sinh có tên bắt đầu bằng chữ 'A':");
            var studentsWithA = student.Where(s => s.name.StartsWith("A")).ToList();

            if (studentsWithA.Any())
            {
                foreach (var s in studentsWithA)
                {
                    s.xuat();
                }
            }
            else
            {
                Console.WriteLine("Không có học sinh nào có tên bắt đầu bằng chữ 'A'");
            }


            Console.WriteLine("===========================");
            //d. Tổng tuổi của tất cả học sinh
            Console.WriteLine("d. Tổng tuổi của tất cả học sinh:");
            int SumAge = student.Sum(s => s.age);
            Console.WriteLine("Tổng tuổi: " + SumAge);



            Console.WriteLine("===========================");
            //e. Học sinh có tuổi lớn nhất
            Console.WriteLine("e. Học sinh có tuổi lớn nhất:");
            var HocSinhLonNhat = student.OrderByDescending(s => s.age).FirstOrDefault();

            if (HocSinhLonNhat != null)
            {
                HocSinhLonNhat.xuat();
            }
            else
            {
                Console.WriteLine("Không có học sinh nào trong danh sách.");
            }





            Console.WriteLine("===========================");
            //f. Danh sách học sinh theo tuổi tăng dần
            Console.WriteLine("f. Danh sách học sinh theo tuổi tăng dần:");
            var SapXep = student.OrderBy(s => s.age).ToList();

            foreach (var s in SapXep)
            {
                s.xuat();
            }

            Console.ReadLine();
        }
    }
}
