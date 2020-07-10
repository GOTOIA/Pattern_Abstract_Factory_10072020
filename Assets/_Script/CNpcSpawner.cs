using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CNpcSpawner : MonoBehaviour
{
    IHuman humanBeggar;
    IAnimal AnimalCat;

    //Factory Type
    private CAbstractFactory factory;
    

   

    //Test Factory NPC

    //Spwan Npc type human
    public void SpwanHumans()
    {

        factory = CFactoryProducer.GetFactory(FactoryType.Human);

        humanBeggar = factory.GetHuman(NPCHumanType.Beggar);

        humanBeggar.Speak();

    }

    //Spwan Npc type Animal
    public void SpwanAnimals()
    {

        factory = CFactoryProducer.GetFactory(FactoryType.Animal);

        AnimalCat = factory.GetAnimal(NPCAnimalType.Cat);

        AnimalCat.Voice();

    }

    public void Start()
    {
        SpwanHumans();
        SpwanAnimals();
    }
}
