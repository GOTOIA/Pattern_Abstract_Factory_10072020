using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAnimalFactory : MonoBehaviour
{
    //Création de la fonction fabrique d'objets relatif au type NPCAnimalType
    public IAnimal GetAnimal(NPCAnimalType animalType)
    {
        switch (animalType)
        {
            case NPCAnimalType.Cat: return new CCat();
            case NPCAnimalType.Dog: return new CDog();
            default: return null;
        }

    }
}
