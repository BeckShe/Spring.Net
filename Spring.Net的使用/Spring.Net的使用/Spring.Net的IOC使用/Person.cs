using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Net的IOC使用
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student student { get; set; }
        public string SayHello()
        {
            return "hello python  "+Name+","+student.Age;
        }
    }
}
