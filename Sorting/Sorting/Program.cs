using System;
using System.Net.Mail;

namespace Sorting
{
    class Program
    {
        static void Main()
        {
            Sort sort = new Sort();
            /*
            for (int i=0; i < array.Length; ++i)
            {
                array[i] = new Random().Next(10);
                Console.Write("{0} ", array[i]);
            }*//*
            int[] array = { 3, 7, 13, 5, 2, 11, 2, 13, 10 };
            Console.WriteLine();
            sort.QuickSort(array);
            for (int i = 0; i < array.Length; ++i)
                Console.Write("{0} ", array[i]);
            */


            using (SmtpClient client = new SmtpClient())
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("t.t@t.t");
                    //mail.To.Add(new MailAddress("е@mail.s"));
                    //throw new SmtpFailedRecipientException();

                    client.Host = "localhost";
                    client.Port = 25;
                    //client.EnableSsl = true;

                    client.Send(mail);
                }
                catch (Exception e)
                {
                    var t = new SmtpFailedRecipientException("bad");
                    var rx = e;
                }
            }
        }
    }
}
