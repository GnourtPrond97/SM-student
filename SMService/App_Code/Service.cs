using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    private StudentDbContext db = new StudentDbContext();

  
    [DataMember]
    public List<Student> ListStudent
    {
        get { return db.Students.ToList(); }
    }
    public Student AddStudent(string id, string name, string dateOfBirth, int gender, string email, string description)
    {
        var student = new Student()
        {
            Id = id,
            Name = name,
            DateOfBirth = dateOfBirth,
            Gender = gender,
            Email = email,
            Description = description
        };

        db.Students.Add(student);
        db.SaveChanges();
        return student;
    }

    public Student EditStudent(string id, string name, string dateOfBirth, int gender, string email, string description)
    {

        var student = db.Students.Find(id);
        if(student== null)
        {
            return null;
        }
        student.Name = name;
        student.DateOfBirth = dateOfBirth;
        student.Gender = gender;
        student.Email = email;
        student.Description = description;
       
        db.Entry(student);
        db.SaveChanges();
        return student;
    }

    public string GetData(int value)
    {
        throw new NotImplementedException();
    }

    public CompositeType GetDataUsingDataContract(CompositeType composite)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetNewStudent()
    {
       
        return ListStudent;
    }

    public Student UpdateStudentInfo(string id, string name, string dateOfBirth, int gender, string email, string description)
    {
        var student = db.Students.Find(id);
        if (student == null)
        {
            return null;
        }
        student.Name = name;
        student.DateOfBirth = dateOfBirth;
        student.Gender = gender;
        student.Email = email;
        student.Description = description;

        db.Entry(student);
        db.SaveChanges();
        return student;
    }
}
