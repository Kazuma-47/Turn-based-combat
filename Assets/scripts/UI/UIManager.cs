using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
   [SerializeField] private GameObject AtkMenu;
   [SerializeField] private GameObject MainMenu;

   public void ChangeUIAtk()
   {
      AtkMenu.SetActive(true);
      MainMenu.SetActive(false);
   }

   public void ChangeUIMenu()
   {
      AtkMenu.SetActive(false);
      MainMenu.SetActive(true);
   }
   public void updateUI()
   {
        
   }
}
