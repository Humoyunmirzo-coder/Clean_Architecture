using EF_Core;
using EFCoreTutorials.Models;

/*   using (var context = new SchoolContext())
   {
       var std = new Student()
       {
           FirstName = "Bill",
           LastName = "Gates"

       };
   Console.WriteLine("1 ");

       context.SaveChanges();
*/



var stud = new Student() { StudentId = 1, Name = "Bill" };

stud.Name = "Steve";

using (var context = new SchoolContext())
{
    context.Update<Student>(stud);

    // or the followings are also valid
    // context.Students.Update(stud);
    // context.Attach<Student>(stud).State = EntityState.Modified;
    // context.Entry<Student>(stud).State = EntityState.Modified; 

    context.SaveChanges();
}
