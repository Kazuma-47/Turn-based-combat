using TMPro;
using UnityEngine;


public class UIManager : MonoBehaviour
{
   [SerializeField] private GameObject atkMenu;
   [SerializeField] private GameObject mainMenu;
   [SerializeField] private TextMeshProUGUI[] moveButtons = new TextMeshProUGUI[3];



   public void ChangeUIAtk()     //switches menu in UI
   {
      atkMenu.SetActive(true);
      mainMenu.SetActive(false);
   }

   public void SetCharacterUI(Players character)      //fills in Ui info of the player 
   {
      
      for (int i = 0; i < moveButtons.Length; i++)
      {
         if (character.moves[i] == null) return;
         moveButtons[i].text = character.moves[i].name;
      }
   }
   public void ChangeUIMenu()             //switches the menu back
   {
      atkMenu.SetActive(false);
      mainMenu.SetActive(true);
   }
   
}
