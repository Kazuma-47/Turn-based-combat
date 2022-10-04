using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   [SerializeField] private GameObject AtkMenu;
   [SerializeField] private GameObject MainMenu;
   [SerializeField] private TextMeshProUGUI[] SelectableMoves = new TextMeshProUGUI[3];



   public void ChangeUIAtk()
   {
      AtkMenu.SetActive(true);
      MainMenu.SetActive(false);
   }

   public void SetCharacterUI(Players character)
   {
      
      for (int i = 0; i < SelectableMoves.Length; i++)
      {
         if (character.Moves[i] == null) break;
         SelectableMoves[i].text = character.Moves[i].name;
      }
   }
   public void ChangeUIMenu()
   {
      AtkMenu.SetActive(false);
      MainMenu.SetActive(true);
   }

   public void ShowSelectable()
   {
      
   }
}
