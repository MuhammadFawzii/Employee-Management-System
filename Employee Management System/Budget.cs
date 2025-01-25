namespace Employee_Management_Application
{
    internal class Budget
    {
        private int id;
        private double value;

        // Constructor
        public Budget(int _id, double _value)
        {
            this.id = _id;
            this.value = _value;
        }
        // Properties
        public int Id
        {
            get => id;
            private set => this.value = value;
        }
        public double Value
        {
            get => value;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value must be a positive number.");
                }
                this.value = value;
            }
        }

        public void increaseBudget(double amount)
        {
            value += amount;
        }
        public override string ToString()
        {
            return $"Budget Id : {Id}\nBudget Value : {Value}";
        }
        public string Print()
        {
            return ToString();
        }
    }
}
