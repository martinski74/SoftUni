namespace _01.EventImplementation
{
    public class NameChangeEventArgs
    {
        private string name;

        public NameChangeEventArgs(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
    }
}
