using System;

namespace first_Assigment
{
    public class Personalinfo
    {
        public int Id { get; set; }


        public string Name;
        public string Gender;
        public DateTime Dob;

       public Personalinfo() 
        {
            Name = "name";
            Gender = "gender"; 
            Dob = DateTime.Now;
        }
        public void Getlist()
        {
            Console.WriteLine("{0}----{1}----{2}", Name, Gender , Dob);
        }
    }
}
