using System;

public class Student
{
	public Student()
	{
	public string Name { get; set; }
	public int Birthmonths { get; set; }
	public int Birthday { get; set; }

	public Student()
	{ }

	public Student(string name,int birthmonths,int birthday) 
	{
		this.Name = name;
		this.Birthmonths = birthmonths;
		this.Birthday = birthday;
	
	}


	}
}
