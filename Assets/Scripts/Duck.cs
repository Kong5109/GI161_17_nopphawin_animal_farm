using UnityEngine;

public class Duck : Animal
{
    public int DuckFeather { get => duckFeather; set => duckFeather = (value < 0) ? 0 : value; }

    private int duckFeather;

    public void Init(string newName)
    {
        base.Init(newName);
        PreferedFood = FoodTpye.Algea;
    }
    public override void MakeSound()
    {
        Debug.Log($"{Name} | Make Sound Quack Quack!!!");
    }

    public override string Produce()
    {
        int produceDuckFeather = 0;
        if (Happiness <= 50)
        {
            produceDuckFeather = 2;
        }
        if (Happiness >= 51 && Happiness <= 59)
        {
            produceDuckFeather = 6;
        }
        else if (Happiness >= 60)
        {
            produceDuckFeather = 8;
        }
        Debug.Log($"{Name} | Produce Duck feather {produceDuckFeather} units");
        return $"{Name} | Produce Duck Feather {produceDuckFeather} units";
    }
}
