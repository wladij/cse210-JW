[Serializable]
class ChecklistGoal : Goal
{
    private int targetCount;
    private int bonus;
    private int completedTimes;

    public int TargetCount { get { return targetCount; } }
    public int Bonus { get { return bonus; } }

    public ChecklistGoal(string name, int value, int targetCount, int bonus) : base(name, value)
    {
        this.targetCount = targetCount;
        this.bonus = bonus;
        completedTimes = 0;
    }

    public override int RecordEvent()
    {
        if (!Completed)
        {
            completedTimes++;
            if (completedTimes == targetCount)
            {
                Completed = true;
                return Value + bonus;
            }
            return Value;
        }
        return 0;
    }

    public override string GetDescription()
    {
        return $"{Name} (Checklist: Completed {completedTimes}/{targetCount} times)";
    }
}