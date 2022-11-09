using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using EfCoreTest1;

using (ApplicationContext db = new ApplicationContext())
{
    var users = db.Sotrudniks.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Sotrudnik u in users)
    {
        Console.WriteLine(u.Fio + " - " + u.Age);
    }
}

using (ApplicationContext db = new ApplicationContext())
{
    Sotrudnik test = new Sotrudnik { SotrudnikId = 1, Fio = "Krivosheev Mihail Ivanovich", Doljnost = "Boss", Age = "49" };
    db.Sotrudniks.Add(test);
    db.SaveChanges();
    var sotrudniks = db.Sotrudniks.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Sotrudnik u in sotrudniks)
    {
        Console.WriteLine(u.Fio + " - " + u.Age);
    }
}


using (ApplicationContext db = new ApplicationContext())
{
    Sotrudnik? upduser = (from sotrudnik in db.Sotrudniks where sotrudnik.SotrudnikId == 1 select sotrudnik).First();
    if (upduser != null)
    {
        upduser.Age = upduser.Age = ("18");
        db.SaveChanges();
    }
    var users = db.Sotrudniks.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Sotrudnik u in users)
    {
        Console.WriteLine(u.Fio + " - " + u.Age);
    }

}

using (ApplicationContext db = new ApplicationContext())
{
    Sotrudnik? deluser = (from sotrudnik in db.Sotrudniks where sotrudnik.SotrudnikId == 2 select sotrudnik).First();
    if (deluser != null)
    {
        db.Sotrudniks.Remove(deluser);
        db.SaveChanges();
    }
    var sotrudniks = db.Sotrudniks.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Sotrudnik u in sotrudniks)
    {
        Console.WriteLine(u.Fio + " - " + u.Age);
    }

}
