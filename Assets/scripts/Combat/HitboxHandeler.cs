using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxHandeler : MonoBehaviour
{

    
    public Enemie ReturnSelected()
    {
        Enemie target = GetComponent<CharacterLoader>()._playerInfo;
        return target;
    }
}
