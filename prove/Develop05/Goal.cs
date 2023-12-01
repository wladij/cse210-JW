[Serializable]
class Goal
{
    public string Name { get; private set; }
    public int Value { get; private set; }
    public bool Completed { get; set; }

    public Goal(string name, int value)
    {
        Name = name;
        Value = value;
        Completed = false;
    }

    public virtual int RecordEvent()
    {
        if (!Completed)
        {
            Completed = true;
            return Value;
        }
        return 0;
    }

    public virtual string GetDescription()
    {
        return Name;
    }

    public override string ToString()
    {
        string status = Completed ? "[X]" : "[ ]";
        return $"{status} {GetDescription()}";
    }
}
