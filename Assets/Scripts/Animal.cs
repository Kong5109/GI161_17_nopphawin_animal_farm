using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public string Name { get => name; private set => name = (string.IsNullOrEmpty(value)) ? "Unknow Animal" : value; }
    public int Hunger { get => hunger; private set => hunger = (value < 0) ? 0 : (value > 50) ? 50 : value; }
    public int Happiness { get => happiness; private set => happiness = (value < 0) ? 0 : (value > 50) ? 50 : value; }

    private string name;
    private int hunger;
    private int happiness;

    public void Init(string newName, int newHunger, int newHappiness)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
    }

    public void AdjustHunger(int newHunger)
    {
        Hunger += newHunger;
    }

    public void AdjustHappiness(int newHappiness)
    {
        Happiness += newHappiness;
    }

    public virtual void MakeSound()
    {
        Debug.Log($"{Name} | !!! Make Sound !!!");
    }

    public void Feed(int foodAmount)
    {
        AdjustHunger(-foodAmount);
        Debug.Log($"{Name} | Get food {foodAmount} unit");
    }

    public void Feed(string foodName, int foodAmount)
    {
        AdjustHunger(-foodAmount);
        Debug.Log($"{Name} | Get food {foodName} : {foodAmount} unit");
    }

    public void GetStatus()
    {
        Debug.Log($"{Name} => Hunger: {Hunger} | Happiness: {Happiness}");
    }
}
