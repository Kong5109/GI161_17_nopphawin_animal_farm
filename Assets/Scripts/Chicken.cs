using UnityEngine;

public class Chicken : Animal
{
    public int Egges { get => egges; private set => egges = (value < 0) ? 0 : value; }

    private int egges;

    public void Init(string newName)
    {
        base.Init(newName);
        PreferedFood = FoodTpye.Grain;
    }
    public void Sleep()
    {
        Debug.Log($"{Name} | Sleep Now");
        AdjustHunger(2);
        AdjustHappiness(4);
    }
    public override void MakeSound()
    {
        Debug.Log($"{Name} | Make Sound pok pok pok POKKK!!!");
    }

    public override string Produce()
    {
        int produceEgg = 0;
        if (Happiness >= 51 && Happiness <= 79)
        {
            produceEgg = 2;
        } else if (Happiness >= 80)
        {
            produceEgg = 3;
        }
        Debug.Log($"{Name} | Produce Egg {produceEgg} units");
        return $"{Name} | Produce Egg {produceEgg} units";
    }
}
