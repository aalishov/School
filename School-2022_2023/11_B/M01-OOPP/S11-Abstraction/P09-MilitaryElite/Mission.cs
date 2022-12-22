using System;
using System.Collections.Generic;
using System.Text;

public class Mission : IMission
{
    public string CodeName { get; private set; }
    public State State { get; private set; }

    public void CompleteMission()
    {
        State = State.Finished;
    }

    public override string ToString()
    {
        return $"Code Name: {CodeName} State: {State}";
    }
}
