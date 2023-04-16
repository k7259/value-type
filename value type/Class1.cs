using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_type
{
	 public class Class1
	{
		public void Changedata(int i)
		{
			i = 20;

		}
		public void Changedata(Student s)
		{
			s.i = 20;

		}
		public void Changedata(string s)
		{
			s = "sonu";

		}
	}
	public class Student
	{
		public int i { get; set; }
	}
}
