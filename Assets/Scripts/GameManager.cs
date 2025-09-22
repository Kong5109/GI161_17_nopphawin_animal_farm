using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Chicken chicken;
    [SerializeField] private Cow cow;
    [SerializeField] private Duck duck;

    [SerializeField] private List<Animal> animalFarm = new List<Animal>();  
    private void Start()
    {
        //Init stat on every animal
        chicken.Init("KaiPop", 10, 10);
        cow.Init("Yokert", 20, 10);
        duck.Init("PedYang", 20, 20);

        //Add animal to list
        animalFarm.Add(chicken);
        animalFarm.Add(cow);
        animalFarm.Add(duck);

        //Display Title game
        Debug.Log($"Welcom to happy farm, there are {animalFarm.Count} living here");

        //Display all animal status in List
        Debug.Log("");
        foreach (Animal animal in animalFarm)
        {
            animal.GetStatus();
        }

        //Display Make Sound and Feed
        Debug.Log("");
        foreach (Animal animal in animalFarm)
        {
            animal.MakeSound();
            animal.Feed(5);
        }

        //Chicken feed food with name and unique Method
        Debug.Log("");
        chicken.Feed("Cookie",5);
        chicken.Sleep();

        //Cow feed food with name and unique Method
        Debug.Log("");
        cow.Feed("grass", 10);
        cow.Moo();

        //Duck feed food with name and unique Method
        Debug.Log("");
        duck.Feed("Worm", 5);
    }
}
