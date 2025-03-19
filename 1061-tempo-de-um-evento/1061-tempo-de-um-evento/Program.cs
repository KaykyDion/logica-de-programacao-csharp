using System;

namespace _1061_tempo_de_um_evento
{
    class Program
    {
        static void Main(string[] args)
        {
            int starDay, startHour, startMinute, startSecond;
            int endDay, endHour, endMinute, endSecond;
            int rest;

            starDay = int.Parse(Console.ReadLine().Split(' ')[1]);
            string[] timeStart = Console.ReadLine().Split(':');
            startHour = int.Parse(timeStart[0]);
            startMinute = int.Parse(timeStart[1]);
            startSecond = int.Parse(timeStart[2]);

            endDay = int.Parse(Console.ReadLine().Split(' ')[1]);
            string[] timeEnd = Console.ReadLine().Split(':');
            endHour = int.Parse(timeEnd[0]);
            endMinute = int.Parse(timeEnd[1]);
            endSecond = int.Parse(timeEnd[2]);

            int start = (starDay - 1) * 24 * 60 * 60 + startHour * 60 * 60 + startMinute * 60 + startSecond;
            int end = (endDay - 1) * 24 * 60 * 60 + endHour * 60 * 60 + endMinute * 60 + endSecond;


            int days = (end - start) / (24 * 60 * 60);
            rest = (end - start) % (24 * 60 * 60);
            Console.WriteLine(days + " dia(s)");

            int hours = rest / (60 * 60);
            rest = rest % (60 * 60);
            Console.WriteLine(hours + " hora(s)");

            int minutes = rest / 60;
            Console.WriteLine(minutes + " minuto(s)");

            int seconds = rest % 60;
            Console.WriteLine(seconds + " segundo(s)");
        }
    }
}
