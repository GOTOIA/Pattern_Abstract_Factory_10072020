using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CNpcSpawner : MonoBehaviour
{
    IHuman humanBeggar;
    IAnimal AnimalCat;

    //Factory Human
    public CHumanFactroy humanFactroy=default;

    //Factory Animal
    public CAnimalFactory animalFactory=default;

    //Test Factory NPC
    public void SpwanNpc()
    {
        if(humanFactroy && animalFactory)
        {
            humanBeggar = humanFactroy.GetHuman(NPCHumanType.Beggar);

            AnimalCat = animalFactory.GetAnimal(NPCAnimalType.Cat);

            humanBeggar.Speak();

            AnimalCat.Voice();

        }

        return;

    }

    public void Start()
    {
        SpwanNpc();
    }
}
