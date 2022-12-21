﻿using Cst12AnimalFarm;
using System.Net.NetworkInformation;

Grass tr = new Grass(2);
Belladona bel = new Belladona();
Cow kravicka = new Cow(10, "Bětka");
Pig prasatko = new Pig(20, "Lojza");
Tiger tygrik = new Tiger(15, "Chán");
Console.WriteLine(tr + " má " + tr.Energy);
Console.WriteLine(bel);
Console.WriteLine(kravicka + " má " + kravicka.Energy);
Console.WriteLine(prasatko + " má " + prasatko.Energy);
Console.WriteLine(tygrik + " má " + tygrik.Energy);
Console.WriteLine("Pojďme pojíst");
kravicka.Consume(tr);
kravicka.Consume(bel);
prasatko.Consume(tr);
prasatko.Consume(kravicka);
tygrik.Consume(kravicka);
Console.WriteLine(kravicka + " má " + kravicka.Energy);
Console.WriteLine(prasatko + " má " + prasatko.Energy);
Console.WriteLine(tygrik + " má " + tygrik.Energy);
Console.ReadKey();