using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum NPCHumanType { Farmer, Beggar, ShopOwner }

public interface IHuman
{
    void Speak();
}
