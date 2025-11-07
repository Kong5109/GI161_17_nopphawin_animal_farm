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
        chicken.Init("KaiPop");
        cow.Init("Yokert");
        duck.Init("PedYang");
        //Add animal to list
        animalFarm.Add(chicken);
        animalFarm.Add(cow);
        animalFarm.Add(duck);

        //Display Title game
        Debug.Log($"Welcom to happy farm, there are {animalFarm.Count} living here");
        //Display all animal status in List
        Debug.Log("- - - - Show All animal Status - - - -");
        foreach (Animal animal in animalFarm)
        {
            animal.GetStatus();
        }

        Debug.Log("- - - - Cow get favorite food - - - -");
        cow.Feed(Animal.FoodTpye.Hay, 10);
        cow.Produce();
        cow.Feed(Animal.FoodTpye.Hay, 20);
        cow.Produce();

        Debug.Log("- - - - Chicken get Rottenfood - - - -");
        chicken.Feed(Animal.FoodTpye.RottenFood, 15);
        chicken.Produce();
        chicken.Feed(Animal.FoodTpye.RottenFood, 30);
        chicken.Produce();

        Debug.Log("- - - - Feed food 40 unit to Duck 5 times  - - - -");
        duck.Feed(Animal.FoodTpye.Algea,40);
        duck.Feed(Animal.FoodTpye.Algea,40);
        duck.Feed(Animal.FoodTpye.Algea,40);
        duck.Feed(Animal.FoodTpye.Algea,40);
        duck.Feed(Animal.FoodTpye.Algea,40);
        duck.GetStatus();
        duck.Produce();

        Debug.Log("- - - - Show All animal Status - - - -");
        foreach (Animal animal in animalFarm)
        {
            animal.GetStatus();
        }
    }
}
