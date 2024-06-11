using System.Runtime.Serialization;
using System;
using System.Xml.Serialization;


public class User
{
    [XmlAttribute]
    public string name { get; set; }
    [XmlAttribute]
    public int age { get; set; }

    public User() { }

    public User(string name, int age) {
        this.name = name;
        this.age = age;
    }
}

class Program
{
    static void Main (string[] args)
    {
        User user = new User("Artem", 20);

        XmlSerializer serializer = new XmlSerializer(typeof(User));

        using (StreamWriter sw = new StreamWriter("User.xml"))
        {
            serializer.Serialize(sw, user);
        }
    }
}

