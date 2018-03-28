using System.Collections.Generic;
using System.Linq;

public class Family
{
    public List<Person> people = new List<Person>();

    public void AddMember(Person member)
    {
        people.Add(member);
    }

    public Person GetOldestMember()
    {

        int oldestMemberAge = this.people.OrderByDescending(p => p.Age).FirstOrDefault().Age;
        return this.people.FirstOrDefault(p => p.Age == oldestMemberAge);
    }
}

