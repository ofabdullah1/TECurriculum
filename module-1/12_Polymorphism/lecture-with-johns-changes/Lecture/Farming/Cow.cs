namespace Lecture.Farming
{
    public class Cow : FarmAnimal
    {
        public Cow() : base("Cow", "moo")
        {

        }

        public bool GivesMilk { get; set; } = true;
    }
}
