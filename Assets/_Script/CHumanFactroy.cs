using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHumanFactroy : MonoBehaviour
{

    //Création de la fonction fabrique d'objets relatif au type NPCHumanType
    public IHuman GetHuman(NPCHumanType humanType)
    {
        switch (humanType)
        {
            case NPCHumanType.Beggar:return new CBeggar();
            case NPCHumanType.Farmer:return new CFarmer();
            case NPCHumanType.ShopOwner:return new CShopowner();
            default:return null;
        }
       
    }
}
