using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using EfCoreTest1;

namespace EfCoreTest1
{
    public class Uvolnenie
    {
        public int UserId { get; set; }
        public string Data { get; set; }
    
        public string Prichina { get; set; }
    }
}


using (ApplicationContext db = new ApplicationContext())
{
    var users = db.Uvolnenies.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Uvolnenie u in users)
    {
        Console.WriteLine(u.Prichina + " - " + u.Data);
    }
}

using (ApplicationContext db = new ApplicationContext())
{
    Uvolnenie test = new Uvolnenie { UserId = 1, Prichina = poSob };
    db.Uvolnenies.Add(test);
    db.SaveChanges();
    var uvolnenies = db.Uvolnenies.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Uvolnenie u in uvolnenies)
    {
        Console.WriteLine(u.Prichina + " - " + u.Data);
    }
}


using (ApplicationContext db = new ApplicationContext())
{
    Uvolnenie? upduser = (from uvolnenie in db.Uvolnenies where uvolnenie.Id == 1 select uvolnenie).First();
    if (upduser != null)
    {
        upduser.UserId = upduser.UserId = ("2");
        db.SaveChanges();
    }
    var users = db.Uvolnenies.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Uvolnenie u in users)
    {
        Console.WriteLine(u.Prichina + " - " + u.Data);
    }

}

using (ApplicationContext db = new ApplicationContext())
{
    Sotrudnik? deluser = (from uvolnenie in db.Uvolnenies where uvolnenie.UserId == 2 select uvolnenie).First();
    if (deluser != null)
    {
        db.Uvolnenies.Remove(deluser);
        db.SaveChanges();
    }
    var sotrudniks = db.Sotrudniks.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Uvolnenie u in uvolnenies)
    {
        Console.WriteLine(u.Prichina + " - " + u.Data);
    }

}