using ExerciseSet.Entities;
using System.Collections.Generic;

namespace ExerciseSet.Entities
{
    class Course
    {
        public HashSet<Users> A { get; set; }
        public HashSet<Users> B { get; set; }
        public HashSet<Users> C { get; set; }
        public Users Users { get; set; }

        public Course(HashSet<Users> a, HashSet<Users> b, HashSet<Users> c, Users users)
        {
            A = a;
            B = b;
            C = c;
            Users = users;
        }

        public void AddUsersA(Users users)
        {
            A.Add(users);
        }

        public void AddUsersB(Users users)
        {
            B.Add(users);
        }

        public void AddUsersC(Users users)
        {
            C.Add(users);
        }
    }
}
