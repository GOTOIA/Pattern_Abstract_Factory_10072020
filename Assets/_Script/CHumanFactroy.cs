using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHumanFactroy : CAbstractFactory
{
   

    //Création de la fonction fabrique d'objets relatif au type NPCHumanType
    public override IHuman GetHuman(NPCHumanType humanType)
    {
        switch (humanType)
        {
            case NPCHumanType.Beggar:return new CBeggar();
            case NPCHumanType.Farmer:return new CFarmer();
            case NPCHumanType.ShopOwner:return new CShopowner();
            default:return null;
        }
       
    }

    public override IAnimal GetAnimal(NPCAnimalType animalType)
    {
        return null;
    }
}
