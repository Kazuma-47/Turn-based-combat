using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingCenter : MonoBehaviour
{
   private CreatePlayer player;
   private bool activity;

   private void Start()
   {//find the singleton player object
      player = GameObject.Find("Player").GetComponent<CreatePlayer>();
   }

   public void HealPlayer()
   {
      //add 20% of max hp to player
      float healingAmmount = player._player.maxHp/ 100f * 20;
      player._player.Heal((int)healingAmmount);
   }
}
