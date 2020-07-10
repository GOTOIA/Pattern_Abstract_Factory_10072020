using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum FactoryType { Human,Animal}

public class CFactoryProducer : MonoBehaviour
{
    //Création de la fonction fabrique d'objets Factory relatif au type FactoryType
    public static CAbstractFactory GetFactory(FactoryType factoryType)
    {
        switch (factoryType)
        {
            case FactoryType.Human: return new CHumanFactroy();
            case FactoryType.Animal: return new CAnimalFactory();
            default: return null;
        }

        
    }
   
}
