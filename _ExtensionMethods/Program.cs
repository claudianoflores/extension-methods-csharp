﻿using System;

public class ProcessFile {
    public static void Main(string[] args)
    {
        DateTime dt = new DateTime(2023, 01, 10, 10, 10, 45);
        Console.WriteLine(dt.ElapsedTime());

        string s1 = "Good morning dear students";
        Console.WriteLine(s1.Cut(10));
    }
}
