using System.Threading;
using System.Net;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OS kernel threads demo!");
            Thread t1 = new Thread(new ThreadStart(Program.DoRequest));  
            Thread t2 = new Thread(new ThreadStart(Program.DoRequest));  
            t1.Start();  
            t2.Start();          
        }

        public static void DoRequest(){
            var response_text = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8000/");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                response_text = reader.ReadToEnd();
            }

            Console.WriteLine(response_text);
        }
    }
}
