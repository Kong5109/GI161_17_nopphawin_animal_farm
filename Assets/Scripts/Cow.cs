using UnityEngine;

public class Cow : Animal
{
    public float Milk { get => milk; private set => milk = (value < 0) ? 0 : value; }

    private float milk;

    public override void MakeSound()
    {
        Debug.Log($"{Name} | Make Sound moo!");
    }

    public void Moo()
    {
        Debug.Log($"{Name} | mmmMMMOOOooo !!! | Happiness + 10");
        AdjustHappiness(10);
    }
}
