using Cw3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw3.Services
{
    public class MockDbService : IDbService


    {
        private static IEnumerable<Student> _students = new List<Student>
        {
            new Student{IdStudent =1 , FirstName ="Anton", LastName="Antosiewicz", IndexNumber="s122321" },
                new Student{IdStudent =2 , FirstName ="Waldek", LastName="Malewicz", IndexNumber="s352533" },
                    new Student{IdStudent =3 , FirstName ="Pawel", LastName="Stefanczyk", IndexNumber="s435232" },
                        new Student{IdStudent =4 , FirstName ="Przemek", LastName="Stanislawski", IndexNumber="s242332" }
        };


        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
