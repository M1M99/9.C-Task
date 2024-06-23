using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace F
{
    public class Control
    {
        public User? User { get; set; }

        public Control()
        {
            Foo();
        }

        public void Foo() {
                if (File.Exists("person.json"))
                {
                    var ff = File.ReadAllText("person.json");
                    User = JsonSerializer.Deserialize<User>(ff);
                }
                if (User is null)
                {
                    Console.Write("Name : ");
                    var f = Console.ReadLine();
                go:
                    try
                    {
                        Console.Write("Weight : ");
                        var f1 = Convert.ToSingle(Console.ReadLine());
                        User = new User()
                        {
                            Name = f,
                            Weight = f1,
                            Current = DateTime.Now,
                            Litr = 0,
                            History = new List<ListHisstory>(),
                            WaterNorm = Convert.ToSingle(f1 * 0.04)
                        };
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Duz Daxil Et ! ");
                        goto go;
                    }
                }
            } 
        public void SaveChanges()
        {
            var json = JsonSerializer.Serialize(User);
            File.WriteAllText("person.json", json);
        }
        public void d()
        {
            if(User is null)
            {
                throw new Exception();
            }
            Console.WriteLine(User.WaterNorm);
        }

        public void FinishDay()
        {
            if (User is null) throw new Exception("Problem Var !");
            var r = new ListHisstory(User.Current.ToString("dd.MM.yyyy"), User.Litr);
            User.History.Add(r);
            User.Current = User.Current.AddDays(1);
            User.Litr = 0;
        }
        
        public void History()
        {
            if (User.History.Count == 0)
            {
                Console.WriteLine("Have not history.");
            }
            else
            {
                foreach (var record in User.History)
                {
                    Console.Write($"Date: {record.CurrentDate} | Litr: {Convert.ToDouble (record.litr)} | Status : ");
                    if (record.litr >= User.WaterNorm)
                    {
                        Console.WriteLine("Kifayet Qeder Su Ichdiz! ");
                    }
                    else
                    {
                        Console.WriteLine("Chox az su ichmisiz ! ");
                    }
                }
            }
        }
        public void drinkWater()
        {
            if (User is null) throw new Exception("User Has Not");
            Console.Clear();
        go1:
            try
            {
                Console.Write("Litr : (Kesr Eded Daxil Eterken Vergul Istifade Et Eks Halda Tarixchde Tam Eded Kimi Yazilacaq Consola)");
                var t = Convert.ToSingle(Console.ReadLine());
                User.Litr += t;
                Console.Clear() ;
            }
            catch (Exception ex) { 
                goto go1;
            }
        }

    }
}
