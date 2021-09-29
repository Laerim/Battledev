using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Battledev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5 / 2);
            Console.Read();
        }

        private void DEMARRAGE()
        {


        }
        private void RECHERCHE_SUPERIEUR()
        {

            int value = 0;
            string[] stringArray = new string[] { "1", "2", "3", "4" };
            int[] intArray = Array.ConvertAll(stringArray, s => int.Parse(s));
            int count = intArray.Count(s => s > value);


        }
        private void FUSIONNER_ARRAY()
        {

            string[] arOne = new string[] { "1", "2", "3", "4" };
            string[] arTwo = new string[] { "5", "6", "7", "8" };
            arOne = arOne.Concat(arTwo).ToArray();
        }


        private void TEST()
        {
            List<int> lst = new List<int>();
            lst.Sort();
            lst = new List<int>() { 2, 3, 4 };

            for (int i = 0; i <= lst.Count; i++)
            {

            }
            foreach (int t in lst)
            {

            }
            //int count = db.Questions.Count(a => a.Questionnaire.QuestionnaireId == idQuestionnaire);
            int count = lst.Count(a => a == 1);


            List<string> lstString = new List<string>();
            string value = string.Join("", lstString);
        }
        private void WORK_DICTIONNARY()
        {
            Dictionary<string, int> dico = new Dictionary<string, int>();
            if (dico.Keys.Contains("test"))
            {
                dico["test"]++;
                dico.Remove("test");
            }
            else
                dico.Add("test", 1);

            dico.Remove("test");

            Dictionary<string, int> dic = dico.Where(i => i.Value.Equals(1))
         .ToDictionary(i => i.Key, i => i.Value);

            foreach (KeyValuePair<string, int> val in dico)
            {

            }
            

        }
        private void WORK_TIME()
        {
            TimeSpan time = new TimeSpan(8, 20, 30);

        }
        /*static void Main(string[] args)
		{   string line;
		    bool b = true;
            Dictionary<int, Dictionary<TimeSpan, string>> dico = new Dictionary<int, Dictionary<TimeSpan, string>>();
		    while ((line = Console.ReadLine()) != null)
                {
                    Console.Error.WriteLine(line);
                    //
                    // Lisez les données et effectuez votre traitement 
                    //
                    if (b)
                        b = false;
                    else
                    {
                        string[] ar = line.Split(' ');
                        if (!dico.Keys.Contains(int.Parse(ar[0])))
                        {
                            Dictionary<TimeSpan, string> d = new Dictionary<TimeSpan, string>();
                            d.Add(GetTimeSpan(ar[1].Split('-')[0]), "DEBUT");
                            d.Add(GetTimeSpan(ar[1].Split('-')[1]), "FIN");
                            dico.Add(int.Parse(ar[0]), d);
                        }
                        else
                        {
                            dico[int.Parse(ar[0])].Add(GetTimeSpan(ar[1].Split('-')[0]), "DEBUT");
                            dico[int.Parse(ar[0])].Add(GetTimeSpan(ar[1].Split('-')[1]), "FIN");
                        }
                    }
                }
                
                for (int i = 1; i <= 5; i++)
                {
                    if (!dico.Keys.Contains(i))
                    {
                        Console.WriteLine(i.ToString() +" 08:00-8:59");
                        break;
                    }
                    else
                    {
                        Dictionary<TimeSpan, string> d = dico[i];
                        
                    }
                    
                }
                

                // Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
            }
            
           
            
            
            
            private static TimeSpan GetTimeSpan(string val)
            {
                string[] ar = val.Split(':');
               
                TimeSpan t = new TimeSpan(int.Parse(ar[0]), int.Parse(ar[1]),0);
                return t;
            }

			// Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
		}*/
    }
}

