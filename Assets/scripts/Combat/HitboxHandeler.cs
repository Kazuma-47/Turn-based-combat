using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxHandeler : MonoBehaviour
{

    
    public Players ReturnSelected()
    {
        Players target = GetComponent<CharacterLoader>()._playerInfo;
        return target;
    }
}
