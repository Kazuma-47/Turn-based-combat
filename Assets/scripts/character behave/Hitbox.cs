using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    public TurnManager TM;
    
        void OnMouseDown()
        {
        if (TM.canSelect==true)
        PlayerPrefs.SetString("Selected", this.gameObject.name);
        
        }
   
}
