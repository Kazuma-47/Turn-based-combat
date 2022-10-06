using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   [SerializeField] private GameObject atkMenu;
   [SerializeField] private GameObject mainMenu;
   [SerializeField] private TextMeshProUGUI[] selectableMoves = new TextMeshProUGUI[3];



   public void ChangeUIAtk()     //switches menu in UI
   {
      atkMenu.SetActive(true);
      mainMenu.SetActive(false);
   }

   public void SetCharacterUI(Players character)      //fills in Ui info of the player 
   {
      
      for (int i = 0; i < selectableMoves.Length; i++)
      {
         if (character.moves[i] == null) break;
         selectableMoves[i].text = character.moves[i].name;
      }
   }
   public void ChangeUIMenu()             //switches the menu back
   {
      atkMenu.SetActive(false);
      mainMenu.SetActive(true);
   }
   
}
