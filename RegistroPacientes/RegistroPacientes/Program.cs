//Jambriel Calderon Ortiz 2025-0914

using System;

class Patient
{
    public string name;
    public int age;
    public string Cedula;
    public string disease;

    public Patient(string n, int a, string id, string d)
    {
        name = n;
        age = a;
        Cedula = id;
        disease = d;
    }

    public void Show()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Cedula Number: " + Cedula);
        Console.WriteLine("Disease: " + disease);
        Console.WriteLine("-----------------------------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Patient[] patients = new Patient[50];
        int count = 0;
        int option = 0;

        while (option != 6)
        {
            Console.WriteLine("------- MENU -------");
            Console.WriteLine("1- Register patient");
            Console.WriteLine("2- Show patients");
            Console.WriteLine("3- Search by Cedula");
            Console.WriteLine("4- Edit patient");
            Console.WriteLine("5- Delete patient");
            Console.WriteLine("6- Exit");
            Console.Write("Choose an option: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Cedula Number: ");
                string Cedula = Console.ReadLine();

                Console.Write("Disease: ");
                string disease = Console.ReadLine();

                patients[count] = new Patient(name, age, Cedula, disease);
                count++;

                Console.WriteLine("Patient saved!\n");
            }
            else if (option == 2)
            {
                if (count == 0)
                {
                    Console.WriteLine("No patients registered.\n");
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        patients[i].Show();
                    }
                }
            }
            else if (option == 3)
            {
                Console.Write("Enter the Cedula number: ");
                string search = Console.ReadLine();

                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (patients[i].Cedula == search)
                    {
                        Console.WriteLine("Patient found:");
                        patients[i].Show();
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("No patient found with that Cedula.\n");
                }
            }
            else if (option == 4)
            {
                Console.Write("Enter the Cedula to edit: ");
                string editCedula = Console.ReadLine();

                bool edited = false;

                for (int i = 0; i < count; i++)
                {
                    if (patients[i].Cedula == editCedula)
                    {
                        Console.Write("New Name: ");
                        patients[i].name = Console.ReadLine();

                        Console.Write("New Age: ");
                        patients[i].age = int.Parse(Console.ReadLine());

                        Console.Write("New Cedula: ");
                        patients[i].Cedula = Console.ReadLine();

                        Console.Write("New Disease: ");
                        patients[i].disease = Console.ReadLine();

                        Console.WriteLine("Patient updated!\n");
                        edited = true;
                        break;
                    }
                }

                if (!edited)
                {
                    Console.WriteLine("No patient found with that Cedula.\n");
                }
            }
            else if (option == 5)
            {
                Console.Write("Enter the Cedula to delete: ");
                string deleteCedula = Console.ReadLine();

                bool deleted = false;

                for (int i = 0; i < count; i++)
                {
                    if (patients[i].Cedula == deleteCedula)
                    {
                        for (int j = i; j < count - 1; j++)
                        {
                            patients[j] = patients[j + 1];
                        }

                        patients[count - 1] = null;
                        count--;

                        Console.WriteLine("Patient deleted!\n");
                        deleted = true;
                        break;
                    }
                }

                if (!deleted)
                {
                    Console.WriteLine("No patient found with that Cedula.\n");
                }
            }
            else if (option == 6)
            {
                Console.WriteLine("Exiting system...");
            }
            else
            {
                Console.WriteLine("Invalid option.\n");
            }
        }

        Console.ReadKey();
    }
}
