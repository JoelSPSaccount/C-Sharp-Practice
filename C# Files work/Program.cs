using System.Diagnostics;
byte[] logo = File.ReadAllBytes("sps.bmp");
byte first = logo[0];
byte second = logo[1];
foreach (byte b in logo){}
Console.WriteLine(first);