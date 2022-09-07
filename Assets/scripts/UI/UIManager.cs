using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
   public GameObject AtkMenu;
   public GameObject MainMenu;

   public void ChangeUIAtk()
   {
      AtkMenu.SetActive(true);
      MainMenu.SetActive(false);
   }

   public void updateUI()
   {
        
   }
}
