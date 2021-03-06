using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var persons = new List<Person>(){
			new Person {
				id = 100,
				Name = "Test person 1",
				DepartmentId = 1000
			},
			new Person {
				id = 101,
				Name = "Test person 2",
				DepartmentId = 1001
			},
			new Person {
				id = 101,
				Name = "Test person 3",
				DepartmentId = 1003
			}
		};
		
		persons = persons.OrderByDescending(x => x.DepartmentId == 1003).ToList();
		
		foreach(var person in persons) {
			Console.WriteLine(person.Name + " ->" + person.DepartmentId);
		}
	}
}

public class Person
{
    public int id { get; set; }
    public string Name { get; set; }
    public int DepartmentId { get; set; }
}
