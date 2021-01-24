using System;
using System.Collections.Generic;
using System.IO;


namespace MailingSolution
{
    public static class Database
    {
        public static List<string> Templates { get; set; } = new List<string>();
        

        static Database()
        {
            
        }

        //Saving data
        public static void SaveData()
        {
            string path="templates.txt";
            File.WriteAllText(path, String.Empty);
            using (StreamWriter sw = new StreamWriter("templates.txt"))
            {
                
                foreach (string t in Templates)
                {
                    sw.WriteLine(t);
                }
            }
            
            
        }

        //generating list from file
        public static List<string> LoadData()
        {
            using (StreamReader rd = new StreamReader("templates.txt"))
            {
                string line;
                while((line = rd.ReadLine()) != null)  
                {  
                    Templates.Add(line);
                } 
            }

            return Templates;
        }
    }
}
