using TMPro;
using UnityEngine;


public class UIManager : MonoBehaviour
{
   [SerializeField] private GameObject atkMenu;
   [SerializeField] private GameObject mainMenu;
   [SerializeField] private TextMeshProUGUI[] moveButtons = new TextMeshProUGUI[3];
   [SerializeField] private TextMeshProUGUI healthStats;
   [SerializeField] private TextMeshProUGUI characterName;
   [SerializeField] private TextMeshProUGUI titlePrompt;
   [SerializeField] private TextMeshProUGUI infoPrompt;
   private string defaultPrompt = "Choose your next attack: ";
   private Players playerCharacter;
   


   public void ChangeUIMenu()             //switches the menu back
   {
      if (atkMenu.activeSelf == false)
      {
         atkMenu.SetActive(true);
         mainMenu.SetActive(false);
      }
      else
      {
         atkMenu.SetActive(false);
         mainMenu.SetActive(true);
      }
   
   }
   
   public void SetCharacterUI(Players _character)      //fills in Ui info of the player 
   {
      playerCharacter = _character;
      characterName.text = "Name: " + _character.name;
      healthStats.text = _character.currentHp + "/" + _character.maxHp;
      for (int i = 0; i < moveButtons.Length; i++)
      {
         if (_character.moves[i] == null) return;
         moveButtons[i].text = _character.moves[i].name;
      }
   }
   public void UpdateUI()
   {
      characterName.text = "Name: " + playerCharacter.name;
      healthStats.text = playerCharacter.currentHp + "/" + playerCharacter.maxHp;
   }

   public void HoverPrompt(int _move)
   {
      var player = GetComponent<TurnManager>().player;
      titlePrompt.text = player.moves[_move].name;
      infoPrompt.text = player.moves[_move].GetInfo();
   }

   public void ResetHoverPrompt()
   {
      titlePrompt.text = defaultPrompt;
      infoPrompt.text = "";
   }
   
   

   
}
