using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classe abstraite factory
public abstract class CAbstractFactory
{
    public abstract IHuman GetHuman(NPCHumanType humanType);
    public abstract IAnimal GetAnimal(NPCAnimalType animalType);
}
