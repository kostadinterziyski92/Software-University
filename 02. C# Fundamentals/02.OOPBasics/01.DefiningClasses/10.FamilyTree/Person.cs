using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private string birhtDay;
    private List<Person> parents;
    private List<Person> children;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string BirthDay
    {
        get { return birhtDay; }
        set { birhtDay = value; }
    }

    public List<Person> Parents
    {
        get { return parents; }
        set { parents = value; }
    }

    public List<Person> Children
    {
        get { return children; }
        set { children = value; }
    }

}

