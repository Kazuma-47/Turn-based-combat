using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CreatePlayer createplayer;
    public string Name;
    public int maxHP;
    public int maxstamina;
    public int maxmana;
    public int KitNHealth;
    public int KetsuHealth;
    public int BiaHealth;
    public int RosalinaHealth;
    public int RosalinaStamina;
    public int kEVINHealth;
    public int kEVINStamina;
    private void Start()
    {
        Name = createplayer.Name;
        maxHP = createplayer.maxHP;
        maxstamina = createplayer.maxstamina;
        maxmana = createplayer.maxmana;
        KetsuHealth = PlayerPrefs.GetInt("Ketsuhealth");
        KetsuHealth = PlayerPrefs.GetInt("KetsuStamina");

        KitNHealth = PlayerPrefs.GetInt("47health");
        KitNHealth = PlayerPrefs.GetInt("47Stamina");

        BiaHealth = PlayerPrefs.GetInt("BiaHealth");
        BiaHealth = PlayerPrefs.GetInt("BiaMana");

        RosalinaHealth = PlayerPrefs.GetInt("RosalinaHealth");
        RosalinaStamina = PlayerPrefs.GetInt("RosalinaStamina");

        kEVINHealth = PlayerPrefs.GetInt("kEVINhealth");
        kEVINStamina = PlayerPrefs.GetInt("kEVINStamina");
    }
}
