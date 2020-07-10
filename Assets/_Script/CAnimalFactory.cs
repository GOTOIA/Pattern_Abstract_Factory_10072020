using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CAnimalFactory : CAbstractFactory
{
    //Création de la fonction fabrique d'objets relatif au type NPCAnimalType
    public override IAnimal GetAnimal(NPCAnimalType animalType)
    {
        switch (animalType)
        {
            case NPCAnimalType.Cat: return new CCat();
            case NPCAnimalType.Dog: return new CDog();
            default: return null;
        }

    }

    public override IHuman GetHuman(NPCHumanType humanType)
    {
        return null;
    }
}
