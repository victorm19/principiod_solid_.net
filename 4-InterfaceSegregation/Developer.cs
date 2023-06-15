namespace InterfaceSegregation
{
    public class Developer : IDevelopActivities, IWorkTeamActivities
    {
        public Developer()
        {
        }

        public void Comunicate()
        {
            throw new NotImplementedException();
        }

        public void Develop() 
        {
            Console.WriteLine("I'm developing the functionalities required");
        }

        public void Plan()
        {
            Console.WriteLine("I'm planning the functionalities required");
        }
    }
}