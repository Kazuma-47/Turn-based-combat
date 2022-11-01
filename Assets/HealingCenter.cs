using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingCenter : MonoBehaviour
{
   private CreatePlayer player;
   private bool activity;

   private void Start()
   {
      player = GameObject.Find("Player").GetComponent<CreatePlayer>();
   }

   public void HealPlayer()
   {
      print("healing");
      float healingAmmount = player._player.maxHp/ 100f * 20;
      print(healingAmmount);
      player._player.Heal((int)healingAmmount);
   }
}
