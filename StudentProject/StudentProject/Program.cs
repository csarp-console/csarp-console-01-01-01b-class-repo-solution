using StudentProject;

Student adel = new Student
{
    Name = "Kis Adél",
    Age = 17,
};
Student janos = new Student
{
    Name = "Kis János",
    Age = 17,
};

if (adel.EqualTo(janos))
    Console.WriteLine("Két diák adatai megegyeznek");
else Console.WriteLine("Két diák adatai nem egyeznek meg!");

if (adel.IsYounger(janos))
    Console.WriteLine($"{adel.Name} fiatalabb {janos.Name}");
else if (janos.IsYounger(adel))
    Console.WriteLine($"{janos.Name} fiatalabb {adel.Name}");
else
    Console.WriteLine("A két diák ugyan annyi éves!");