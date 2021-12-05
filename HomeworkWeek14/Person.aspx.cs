/// Chapter No. 12		Exercise No. 1
/// File Name: Person.aspx.cs
/// @author: Zitlali Martinez
/// Date:  December 05, 2021
///
/// Problem Statement: Create a list of Person objects. Find the average height and display the people who meet 
/// the average height or are taller.
/// 
/// Overall Plan:
/// 1) Create a person class 
///     a) Write a constructor for the instance variables
///     b) Write the getters and setters using properties
/// 2) Create a list to hold person objects
/// 3) Create a couple persons and add them to the list
/// 4) Calculate the average height of people in the list
/// 5) Display the persons who's height is greater than or equal to the average
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeworkWeek14
{
    public partial class Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<person> myList = new List<person>();
            person p1 = new person("Mark", 12, 6.2);
            person p2 = new person("John", 15, 5.0);
            person p3 = new person("Rick", 17, 6.0);
            person p4 = new person("Bob", 10, 5.5);

            myList.Add(p1);
            myList.Add(p2);
            myList.Add(p3);
            myList.Add(p4);
            //PView.DataSource = from a in myList select a;
            //PView.DataSource = from a in myList where a.Age <= 12 select a; 
            int personCount = (from pa in myList
                                   //where pa.Age > 18
                               orderby pa.Name, pa.Height, pa.Age
                               select pa).Count();
            double average = 0;
            double sum = 0;
            foreach (var pp in myList)
            {
                sum += pp.Height;
            }
            average = sum / personCount;
            PView.DataSource = from a in myList where a.Height >= average select a;
            PView.DataBind();


        }

        public class person
        {
            private string name;
            private int age;
            private double height;

            public person(string name, int age, double height)
            {
                this.Age = age;
                this.Name = name;
                this.Height = height;
            }

            public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }
            public double Height { get => height; set => height = value; }
        }
    }
}