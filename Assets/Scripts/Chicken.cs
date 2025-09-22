using UnityEngine;

public class Chicken : Animal
{
    public int Egges { get => egges; private set => egges = (value < 0) ? 0 : value; }

    private int egges;

    public override void MakeSound()
    {
        Debug.Log($"{Name} | Make Sound pok pok pok POKKK!!!");
    }

    public void Sleep()
    {
        Debug.Log($"{Name} | Sleep Now");
        AdjustHunger(2);
        AdjustHappiness(4);
    }
}
