



using System.ComponentModel.DataAnnotations;
using EntityFrameWork.Migrations;
using EntityFrameWork.Models;
using Microsoft.EntityFrameworkCore;
using EntityFrameWork;





using var AppDB = new AppDbContext();


var std = AppDB.Students.Include((e) => e.MentorStudents).ThenInclude((e) => e.mentor).Include((e) => e.Club).SingleOrDefault(e => e.Id == 2);



if (std != null)
{
    Console.WriteLine($"Name: {std.Name}");
    Console.WriteLine($"BirthDate: {std.BirthDate.Month}");
    Console.WriteLine($"Age: {std.Age}");
    Console.WriteLine($"Club: {std.Club.ClubName}");
    Console.WriteLine($"Club Category: {std.Club.CategoryName}");
    Console.WriteLine($"Mentors: ");


    Console.WriteLine("-----------------------------------------\n\n");


    foreach (MentorStudent SingleMentorStudent in std.MentorStudents)
    {
        Console.WriteLine($"Name: {SingleMentorStudent.mentor.Name}");
        Console.WriteLine($"Mentor Category: {SingleMentorStudent.mentor.CategoryName}");
        Console.WriteLine($"Sign Date: {SingleMentorStudent.SignDate}");
        Console.WriteLine("-----------------------------------------\n\n");

    }


}







