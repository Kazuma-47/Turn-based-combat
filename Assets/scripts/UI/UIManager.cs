using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   [SerializeField] private GameObject AtkMenu;
   [SerializeField] private GameObject MainMenu;
   [SerializeField] private Slider playerHealthbar;
   [SerializeField] private Slider enemyHealthbar;

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
   public void UpdateUI(int playerHealth , int enemyHealth)
   {
      playerHealthbar.value = playerHealth;
      enemyHealthbar.value = enemyHealth;
   }

   public void SetValues(CharacterStats player, CharacterStats enemy)
   {
      playerHealthbar.maxValue = player.MaxHP;
      playerHealthbar.value = player.currentHP;

      enemyHealthbar.maxValue = enemy.MaxHP;
      enemyHealthbar.value = enemy.currentHP;
   }
}
