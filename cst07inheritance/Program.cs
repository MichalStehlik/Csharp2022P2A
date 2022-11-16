using cst07inheritance;

Human adam = new Human("Adam","Avatar","Liberec");
Human bretislav = new Human { Firstname = "Břetislav", Lastname = "Bohatý", City = "Praha" };
Student cyril = new Student { Firstname = "Cyril", Lastname = "Čáp", City = "Jablonec", Classname = "P2A" };

Console.WriteLine(adam);