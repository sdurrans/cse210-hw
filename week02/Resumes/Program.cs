using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle= "Mechanical Engineer";
        job1._company= "Moog";
        job1._startYear= 2020;
        job1._endYear= 2035;

        Job job2 = new Job();
        job2._jobTitle= "Software Deveolper";
        job2._company= "Halo Studios";
        job2._startYear= 2035;
        job2._endYear= 2050;
    }
} 