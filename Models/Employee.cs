using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.CSharp;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string EmailAddress { get; set; }
    public string Preferred_Contact_Number { get; set; }
    public string Position { get; set; }
    public Dictionary<int, string> Department { get; set; }
    public DateTime StartDate { get; set; }
    public bool EmploymentStatus { get; set; }
    public DateTime TerminationDate { get; set; }
    public enum Shift
    {
        Morning, Afternoon, Evening, Night, Graveyard
    }
    public Employee.Shift WorkShift { get; set; }

   

    /*
·  Shift

·  Manager

·  Team Member Photo

·  Favorite Color
*/
    public Employee()
	{
	}
}
