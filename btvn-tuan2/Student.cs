using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvn_tuan2
{
    internal class Student
    {

        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public Student() { }
        public Student(Student st)
        {
            id = st.id;
            name = st.name;
            age = st.age;
        }
        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public void xuat()
        {
            Console.WriteLine("ma: " + id);
            Console.WriteLine("ten: "+ name);
            Console.WriteLine("tuoi: "+ age);
        }
    }
}
