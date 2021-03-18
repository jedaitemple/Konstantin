using System;
using System.Linq;

namespace Solution2
{
    class Library
    {
        private string firstName;
        private string lastName;
        private int age;
        private int [] amountPaid;
        private string mtaData;

        public Library(string firstName, string lastName, int age, int[] amountPaid, string mtaData1)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.amountPaid = amountPaid;
            this.mtaData = mtaData1;
            check();
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public int [] AmountPaid { get => amountPaid; set => amountPaid = value; }
        public string MtaData { get => mtaData; set => mtaData = value; }
        public void check()
        {


           mtaData= mtaData.Replace("\n", "÷");
                
            
        }
        public string exercise7()
        {
             MtaData = MtaData.Substring(MtaData.IndexOf('÷')+1);
            Console.WriteLine(MtaData);
            return MtaData;
        }
        public string exercise8()
        {
             MtaData = MtaData.Substring(MtaData.LastIndexOf('÷') + 1);
            Console.WriteLine(MtaData);
            return MtaData;
        }
        public void exercise6(string str)
        {
            MtaData = "";
            MtaData = MtaData + str;
            Console.WriteLine(MtaData);
        }
        public void exercise5(string str)
        {//add in the beginning
            check();
            MtaData =  MtaData + str;
            Console.WriteLine(MtaData);
        }
        public void exercise4(string str)
        {//add in the beginning
            MtaData = str+MtaData;
            Console.WriteLine(MtaData);
        }
        public string [] exercise3()
        {
            string[] words = MtaData.Split('÷');
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            return words; 

        }
        public  string exercise2()
        {
            if (MtaData.Contains('÷'))
            {

                int index = MtaData.LastIndexOf("÷");
                string result = MtaData.Split('÷').Last();
                Console.WriteLine(result);
                return result;
             
                


            }
            return null;



        }
        public  string exercise1()
        {

            if (MtaData.Contains('÷'))
            {
                int index = MtaData.IndexOf('÷');
               

               
                    
                    string result = MtaData.Substring(0, index);
                    Console.WriteLine(result);
                return result;
                
            }
            return null;
        }

        static void Main(string[] args)
        {//if we find new line we change it with  ÷
            int[] arr = { 130, 145 };
            string mtaData = "date:17 - 03 - 2021  \n  admin: 30 ÷old: 413.77";
            Library l = new Library("Trevor", "Test", 42, arr, mtaData);
          Console.WriteLine( l.exercise7());
            //exercise2("date:17 - 03 - 2021 ÷admin: 30 ÷old: 413.77");
        }
    }
}
