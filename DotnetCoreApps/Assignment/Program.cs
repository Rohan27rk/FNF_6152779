namespace Assignment
{
    using Assignment.Data;

    internal class Program
    {
        static void Main(string[] args)
        {
            insertStudent();
        }

        private static void insertStudent()
        {
             try
            {
                var DbContext = new StudentsContext();
                var NewStudent = new Students
                {
                    Name = "Rohan",
                    Address = "Nanded",
                    Standard = 10
                };
                DbContext.MyStudents.Add(NewStudent);
                DbContext.SaveChanges();
                Console.WriteLine("Data Added successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void updateExample()
        {
            try
            {
                var dbContext = new StudentsContext();
                var rec = dbContext.MyStudents.Find(1);
                if (rec != null)
                {
                    rec.Name = "The Great Wall";
                    rec.Address = "John Cena";
                    rec.Standard = 12;
                }


                else
                {
                    Console.WriteLine("No record found on this id");
                }
                dbContext.SaveChanges();
                Console.WriteLine("Record updated Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void getAllExample()
        {
            try
            {
                var context = new StudentsContext();
                var records = context.MyStudents.ToList();
                foreach (var record in records)
                {
                    Console.WriteLine(record.Name.ToUpper());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
            }
        }

        private static void deleteExample()
        {
            try
            {
                var context = new StudentsContext();
                var rec = context.MyStudents.Find(1);
                if (rec == null)
                {
                    Console.WriteLine("No Record found to delete");
                    return;
                }
                context.MyStudents.Remove(rec);
                context.SaveChanges();
                Console.WriteLine("Student deleted Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
            }
        }
    }

}
//    Scaffold-DBContext "Data Source=FNFIDVPRE22648;Initial Catalog=FNFTraining;Integrated Security=True;Encrypt=False;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data -Tables "Employee" 