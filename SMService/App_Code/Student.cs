using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for Student
/// </summary>
[DataContract]
public class Student
{
    [DataMember]

    public string Id { get; set; }
    [DataMember]

    public string Name { get; set; }
    [DataMember]

    public string DateOfBirth { get; set; }
    [DataMember]

    public int Gender { get; set; }
    [DataMember]

    public string Email { get; set; }
    [DataMember]

    public string Description { get; set; }

    public Student()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}