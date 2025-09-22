using UnityEngine;

public class Duck : Animal
{
    public override void MakeSound()
    {
        Debug.Log($"{Name} | Make Sound Quack Quack!!!");
    }
}
