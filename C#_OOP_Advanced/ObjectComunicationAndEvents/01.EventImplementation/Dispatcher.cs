namespace _01.EventImplementation
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs e);

    public class Dispatcher
    {
        private string name;
        public event NameChangeEventHandler NameChange;

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        private void OnNameChange(NameChangeEventArgs args)
        {
            NameChange(this, args);
        }
    }
}
