using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    class Library
    {

        public List<Tuple<string, string>> library = new List<Tuple<string, string>>();

    
        public Library(List<Tuple<string, string>> library1)
        {
            this.library = library1;
            
        }
        string Extract(string key) {
            int i = 0;
            string firstkey = "";
            string fistvalue = "";
            string finalvalue = "";
            foreach (Tuple<string, string> tuple in library)
            {
                if (tuple.Item1 == key)
                {
                    firstkey = tuple.Item1;
                    fistvalue = tuple.Item2;
                    finalvalue = firstkey + " " + fistvalue;
                    //Console.WriteLine(string.Format("{0} {1}", tuple.Item1, tuple.Item2));
                    library.RemoveAt(i);
                    return finalvalue;
                }
                i++;



            }
            return null;

        }
        string ExtractLast(string key) {
            //   library.Remove(p => p.Item1 == key);
            string lastkey = "";
            string lastvalue = "";
            int i = 0;
            int count = 0;
            foreach (Tuple<string, string> tuple in library)
            {
                if (tuple.Item1 == key)
                {
                    lastkey = tuple.Item1;
                    lastvalue = tuple.Item2;
                    //Console.WriteLine(string.Format("{0} {1}", tuple.Item1, tuple.Item2));
                    count = i;
                }
                i++;

            }
            string mystr = lastkey + " " + lastvalue;
            if (count > 0)
            {
                library.RemoveAt(count);
                return mystr;
            }
            else { 
                return null;
            }
        }


        void Replace(string key, string value)
        {
            //int i = 1;
            //read value for the first matching key
            // List<string> Listwords = new List<string>();
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == '\n')
                {
                    value = replaceChar(value, '÷', i);
                }

            }
            if (value == "")
            {
                library.RemoveAll(r => r.Item1 == key);
                // Console.WriteLine("Sorry couldn't add value");
            }
            else
            {
                library.RemoveAll(r => r.Item1 == key);
                library.Add(Tuple.Create(key, value));
            }
        

        }
        public String replaceChar(string str, char ch, int index)
        {
            return str.Substring(0, index) + ch + str.Substring(index + 1);
        }
        void Add(string key, string value) {

            for(int i = 0; i < value.Length; i++)
            {
                if (value[i] == '\n')
                {
                    value = replaceChar(value, '÷',i);
                }

            }
            // library.Add(Tuple.Create("bmp", "Foo"));
            if (value == "")
            {
                library.RemoveAll(r => r.Item1 == key);
               // Console.WriteLine("Sorry couldn't add value");
            }
            else
            {

                library.Insert(0, Tuple.Create(key, value));
            }
        }
        void AddLast(string key, string value) {
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == '\n')
                {
                    value = replaceChar(value, '÷', i);
                }

            }
            if (value == "")
            {
                library.RemoveAll(r => r.Item1 == key);
                // Console.WriteLine("Sorry couldn't add value");
            }
            else
            {

                library.Add(Tuple.Create(key, value));
            }
        }
        string [] ReadALL(string key)
        {
            int i = 1;
            //read value for the first matching key
            List<string> Listwords = new List<string>();

            string value;
           
            foreach (Tuple<string, string> tuple in library)
            {
                if (tuple.Item1 == key)
                {
                    value = tuple.Item2;
                    i++;
                    //Console.WriteLine(string.Format("{0} {1}",tuple.Item1, tuple.Item2));

                    Listwords.Add(value);



                }

            }

            string[] values = Listwords.ToArray();
            foreach (var item in values)
            {
                //Console.WriteLine(item.ToString());
            }
            return values;
        }
        string ReadLast(string key)
        {
            //read value for the last matching key
            string lastkey="";
            string lastvalue="";
            string finalvalue = "";
            foreach (Tuple<string, string> tuple in library)
            {
                if (tuple.Item1 == key)
                {
                    lastkey = tuple.Item1;
                    lastvalue = tuple.Item2;
                   // Console.WriteLine(string.Format("{0} {1}", tuple.Item1, tuple.Item2));
                    finalvalue = lastkey + " " + lastvalue;
                    
                }
  
            }
            if(finalvalue != "")
            {
                Console.WriteLine(finalvalue);
                return finalvalue;

            }
            
            return null;
        }


        //Read a value for the first matching supplied key, if no matching key then return an empty string.
        string Read(string key) {
            //read value for the first matching key
            string firstkey="";
            string firstvalue="";
            string finalvalue = "";
            foreach (Tuple<string, string> tuple in library)
            {
                if (tuple.Item1 == key)
                {
                    //Console.WriteLine(string.Format("{0} {1}", tuple.Item1, tuple.Item2));
                    firstkey = tuple.Item1;
                    firstvalue = tuple.Item2;
                    finalvalue=firstkey + " " + firstvalue;
                    return finalvalue;//we return the text for the first key and its value
                    
                }



            }
          
            return null;
        }
        //when reading from the data we have to change  ÷ and the new line
        public void print()
        {
            foreach (Tuple<string, string> tuple in library)
            {
                string myvalue="";
               myvalue = tuple.Item2;
                for (int i = 0; i < myvalue.Length; i++)
                {
                    if (myvalue[i] == '÷')
                    {
                        myvalue = replaceChar(myvalue, '\n', i);
                    }

                }
                Console.WriteLine(string.Format("{0} {1}", tuple.Item1, myvalue));



            }
            // this.library.ToList().ForEach(x => Console.WriteLine(x.Key + " " + x.Value));

        }


        static void Main(string[] args)
        {
            List<Tuple<string, string>> data = new List<Tuple<string, string>>();


            
            data.Add(Tuple.Create("txt", "ads"));
           
           
           
            Library l = new Library(data);
            //l.print();
            l.Add("int","integer \n kosio");
            l.Add("ints", "dali");
            l.Add("ints", "integers");
            l.Add("ints", "How about that");
            l.Add("int", "integer \n kosio");
            l.Add("ints", "da");
            l.AddLast("KOS", "dali");
            l.AddLast("ints","Kosio");
           // l.Replace("ints", ",asd");
            l.print();
          
        }    
    }
}
