using ExerciseSet.Entities;

namespace ExerciseSet.Entities
{
    class Users
    {
        public int Number { get; set; }

        public Users(int number)
        {
            Number = number;
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Users))
            {
                return false;
            }
            Users other = obj as Users;
            return Number.Equals(other.Number);
        }
    }
}
