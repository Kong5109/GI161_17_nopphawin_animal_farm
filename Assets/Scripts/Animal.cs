using Unity.VisualScripting;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public enum FoodTpye
    {
        Hay,
        Grain,
        Algea,
        RottenFood,
        AnimalFood
    }
    public string Name { get => name; private set => name = (string.IsNullOrEmpty(value)) ? "Unknow Animal" : value; }
    public int Hunger { get => hunger; private set => hunger = (value < 0) ? 0 : (value > 100) ? 100 : value; }
    public int Happiness { get => happiness; private set => happiness = (value < 0) ? 0 : (value > 100) ? 100 : value; }
    public FoodTpye PreferedFood { get; protected set; }

    private string name;
    private int hunger;
    private int happiness;

    public void Init(string newName)
    {
        Name = newName;
        Hunger = 50;
        Happiness = 50;
    }

    public void AdjustHunger(int newHunger)
    {
        Hunger += newHunger;
    }

    public void AdjustHappiness(int newHappiness)
    {
        Happiness += newHappiness;
    }


    public void Feed(int foodAmount)
    {
        AdjustHunger(-foodAmount);
        AdjustHappiness(foodAmount / 2);
        Debug.Log($"{Name} | Get food {foodAmount} unit => Happiness {Happiness}");
    }

    public void Feed(FoodTpye foodType, int foodAmount)
    {
        if (foodType == PreferedFood)
        {
            AdjustHunger(-foodAmount);
            AdjustHappiness(15);
            Debug.Log($"{Name} feel !Happy! | Get food {foodType.ToString()} : {foodAmount} unit => Happiness {Happiness}");
        }else if(foodType == FoodTpye.RottenFood)
        {
            AdjustHappiness(-20);
            Feed(0);
        }
        else
        {
            Feed(foodAmount);
        }
    }

    public void GetStatus()
    {
        Debug.Log($"{Name} => Hunger: {Hunger} | Happiness: {Happiness}");
    }
    public abstract void MakeSound();
    public abstract string Produce();
}
