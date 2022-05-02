using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TurnManager : MonoBehaviour
{    public GameObject ketsu;
    [HideInInspector] public GameObject KitN;
    [HideInInspector] public GameObject bia;
    [HideInInspector] public GameObject Menu;
    [HideInInspector] public GameObject Attacks;

    [HideInInspector] public GameObject kEVINArrow;
    [HideInInspector] public GameObject RosalinaArrow;
    [HideInInspector] public GameObject KitNArrow;
    [HideInInspector] public GameObject KetsuArrow;
    [HideInInspector] public GameObject BiaArrow;

    [HideInInspector] public TextMeshProUGUI Name;
    [HideInInspector] public TextMeshProUGUI MaxHP;
    [HideInInspector] public TMP_Text CurrentHP;
    [HideInInspector] public TextMeshProUGUI CurrentStamina;
    [HideInInspector] public TextMeshProUGUI MaxStamina;
    [HideInInspector] public TextMeshProUGUI Attack1;
    [HideInInspector] public TextMeshProUGUI Attack2;
    [HideInInspector] public TextMeshProUGUI Attack3;
    [HideInInspector] public TextMeshProUGUI NextAttck;
    [HideInInspector] public TextMeshProUGUI Cost;

    [HideInInspector] public Slider Stamina;
    [HideInInspector] public Slider Mana;
    [HideInInspector] public Slider Healthbar;
    [HideInInspector] public Gradient gradientHP;
    [HideInInspector] public Image fill;
    [HideInInspector] public Slider EnemyHP;

    public int enemyHP;
    public string Crit;
    public int hp1;
    public int hp2;
    public int hp3;
    public int hp4;
    public int hp5;

   public GameObject ketsuchoice;
    [HideInInspector] public GameObject KitNchoice;
    [HideInInspector] public GameObject biachoice;
    [HideInInspector] public GameObject Faniochoice;
    [HideInInspector] public GameObject Cherentellchoice;

    

    public float timer;
    public bool canSelect=false;
    //round loop
    private void Start()
    {
        RoundStart();
    }

    private void Update()
    {
        //UI updates
        time();
        CurrentStamina.text = Stamina.value.ToString();
        CurrentHP.text = Healthbar.value.ToString();
        fill.color = gradientHP.Evaluate(1f);
        fill.color = gradientHP.Evaluate(Healthbar.normalizedValue);

        
       
        //arise

        if (PlayerPrefs.GetString("Selected") == "hitbox ketsu")
        {
            PlayerPrefs.SetString("Selected", "");
            if (hp1 > 0)
            {
                ketsuchoice.SetActive(false);
                KitNchoice.SetActive(false);
                biachoice.SetActive(false);
                Faniochoice.SetActive(false);
                Cherentellchoice.SetActive(false);
                canSelect = false;
                NextAttck.color = new Color(255, 0, 0);
                NextAttck.text = "Player has to be dead to be revived";
                timer = 5;
            } 
            else if (hp1 < 0|| hp1== 0)
            {
                
                ketsuchoice.SetActive(false);
                KitNchoice.SetActive(false);
                biachoice.SetActive(false);
                Faniochoice.SetActive(false);
                Cherentellchoice.SetActive(false);
                canSelect = false;
                PlayerPrefs.SetInt("Ketsuhealth", 50);                                //target revived
                BiaTurn();
            }
        }
        
    }
    public void RoundStart()
    {

        if (GameObject.FindGameObjectsWithTag("ally").Length > 0)
        {
            allyTurn();
        }
    }

    public void allyTurn()
    {
        if (PlayerPrefs.GetInt("kEVINStamina") > 0)
        {
            RosalinaTurn();
        }
    }

    //character stats en visuals 

    public void kEVINTurn()
    {
        kEVINArrow.SetActive(true);
        Mana.gameObject.SetActive(false);
        Stamina.gameObject.SetActive(true);
        Menu.SetActive(true);
        Attacks.SetActive(false);
        Name.text = "kEVIN";
        Attack1.text = "Roast";
        Attack2.text = "Replay";
        Attack3.text = "Ass Whooping";
        MaxStamina.text = "/100";
        MaxHP.text = "/150";

        Healthbar.maxValue = 150;
        Stamina.maxValue = 100;
        Healthbar.value = PlayerPrefs.GetInt("kEVINhealth");
        Stamina.value = PlayerPrefs.GetInt("kEVINStamina");
    }
    public void RosalinaTurn()
    {
        RosalinaArrow.SetActive(true);
        Mana.gameObject.SetActive(false);
        Stamina.gameObject.SetActive(true);
        Menu.SetActive(true);
        Attacks.SetActive(false);
        Name.text = "Rosalina";
        Attack1.text = "Silent slash";
        Attack2.text = "Darkness cutter";
        Attack3.text = "Retsoku";
        MaxStamina.text = "/100";
        MaxHP.text = "/100";

        Healthbar.maxValue = 100;
        Stamina.maxValue = 100;
        Healthbar.value = PlayerPrefs.GetInt("RosalinaHealth");
        Stamina.value = PlayerPrefs.GetInt("RosalinaStamina");
    }
    public void KetsuTurn()
    {
        KetsuArrow.SetActive(true);
        Mana.gameObject.SetActive(false);
        Stamina.gameObject.SetActive(true);
        Menu.SetActive(true);
        Attacks.SetActive(false);
        Name.text = "Ketsu";
        Attack1.text = "Air slash";
        Attack2.text = "Blazing slash";
        Attack3.text = "Chaos Blade";
        MaxStamina.text = "/100";
        MaxHP.text = "/100";

        Healthbar.maxValue = 100;
        Stamina.maxValue = 100;
        Healthbar.value = PlayerPrefs.GetInt("Ketsuhealth");
        Stamina.value = PlayerPrefs.GetInt("KetsuStamina");
    }
    public void KitNTurn()
    {
        KitNArrow.SetActive(true);
        Menu.SetActive(true);
        Attacks.SetActive(false);
        Mana.gameObject.SetActive(false);
        Stamina.gameObject.SetActive(true);
        Name.text = "47";
        Attack1.text = "Life Beating";  //maak de kleur lime green
        Attack2.text = "Raging Fist";
        Attack3.text = "Healing Fist";
        MaxStamina.text = "/150";
        MaxHP.text = "/100";

        Healthbar.maxValue = 150;
        Stamina.maxValue = 100;
        Healthbar.value = PlayerPrefs.GetInt("47health");
        Stamina.value = PlayerPrefs.GetInt("47Stamina");
    }

      public void BiaTurn()
    {
        BiaArrow.SetActive(true);
        Menu.SetActive(true);
        Attacks.SetActive(false);
        Mana.gameObject.SetActive(true);
        Stamina.gameObject.SetActive(false);
        Name.text = "bia";
        Attack1.text = "Curse";
        Attack2.text = "Ice Barrage";
        Attack3.text = "Inferno";
        MaxStamina.text = "/100";
        MaxHP.text = "/100";

        Healthbar.maxValue = 100;
        Mana.maxValue = 100;
        Healthbar.value = PlayerPrefs.GetInt("BiaHealth");
        Mana.value = PlayerPrefs.GetInt("BiaMana");
    }
    
    //attack buttons
    public void attackMenu()
    {
        Menu.SetActive(false);
        Attacks.SetActive(true);
    }


    public void attackbutton1()
    {
        if (Attack1.text == "Air slash")
        {
            enemyHP = PlayerPrefs.GetInt("EnemyHealth");       //damage op monster met crit
            PlayerPrefs.SetInt("EnemyHealth", enemyHP - 50);

            KetsuArrow.SetActive(false);
            Crit = Critrol();
            if(Crit== "CRIT")
            {
                enemyHP = PlayerPrefs.GetInt("EnemyHealth");       //damage op monster met crit
                PlayerPrefs.SetInt("EnemyHealth", enemyHP - 100);
            }
            KitNTurn();
        }
        else if(Attack1.text== "Life Beating")
        {
            PlayerPrefs.SetString("Selected", "");
            KitNArrow.SetActive(false);
            canSelect = true;
            hp1 = PlayerPrefs.GetInt("Ketsuhealth");
            hp2 = PlayerPrefs.GetInt("47health");
            hp3 = PlayerPrefs.GetInt("Biahealth");
            hp4 = PlayerPrefs.GetInt("kEVINhealth");
            hp5 = PlayerPrefs.GetInt("RosalinaHealth");

            arise();

           



        }
        else if(Attack1.text == "Roast")
        {
            kEVINArrow.SetActive(false);
            enemyHP = PlayerPrefs.GetInt("EnemyHealth");       //damage op monster zonder crit
            PlayerPrefs.SetInt("EnemyHealth", enemyHP - 50);
            Crit = Critrol();
            if (Crit == "CRIT")
            {
                enemyHP = PlayerPrefs.GetInt("EnemyHealth");       //damage op monster met crit
                PlayerPrefs.SetInt("EnemyHealth", enemyHP - 100);
            }
            KetsuTurn();

        }
        else if(Attack1.text=="Silent slash")
        {
            RosalinaArrow.SetActive(false);
            print("Silent slash");
            kEVINTurn();
        }
        else if(Attack1.text== "Curse")
        {
            BiaArrow.SetActive(false);
            print("Curse");            
        }
    } 



    public void attackbutton2()
    {
        if (Attack2.text == "Blazing slash")
        {
            KetsuArrow.SetActive(false);

            print("Blazing slash");
            KitNTurn();
        }
        else if(Attack2.text== "Healing fish")
        {
            KitNArrow.SetActive(false);

            hp1 = PlayerPrefs.GetInt("Ketsuhealth");
            hp2 = PlayerPrefs.GetInt("47health");
            hp3 = PlayerPrefs.GetInt("Biahealth");
            hp4 = PlayerPrefs.GetInt("kEVINhealth");
            hp5 = PlayerPrefs.GetInt("RosalinaHealth");

            print("Healing fish");
            BiaTurn();

        }
        else if(Attack2.text == "Replay")
        {
            kEVINArrow.SetActive(false);

            print("Replay");
            KetsuTurn();

        }
        else if(Attack2.text== "Darkness cutter")
        {
            RosalinaArrow.SetActive(false);

            print("Darkness cutter");
            kEVINTurn();
        }
        else if(Attack2.text== "Ice Barrage")
        {
            BiaArrow.SetActive(false);

            print("Ice Barrage");            
        }
    }    




    public void attackbutton3()
    {
        if (Attack3.text == "Chaos Blade")
        {
            KetsuArrow.SetActive(false);

            print("Chaos Blade");
            KitNTurn();
        }
        else if(Attack3.text== "Pirina present")
        {
            KitNArrow.SetActive(false);

            print("Pirina present");
            BiaTurn();

        }
        else if(Attack3.text == "Ass Whooping")
        {
            kEVINArrow.SetActive(false);

            print("Ass Whooping");
            KetsuTurn();

        }
        else if(Attack3.text== "Retsoku")
        {
            RosalinaArrow.SetActive(false);

            print("Retsoku");
            kEVINTurn();
        }
        else if(Attack3.text== "Inferno")
        {
            BiaArrow.SetActive(false);

            print("Inferno");            
        }
    } 


    public string Critrol()
    {
        string crit ="";
        int nummer = Random.Range(1, 10);
        switch (nummer)
        {
            case 4:
                crit = "CRIT";
                break;
            case 7:
                crit = "CRIT";
                break;
        }
        return crit;
        
    }

  public void arise()
    {


        ketsuchoice.SetActive(true);
        KitNchoice.SetActive(true);
        biachoice.SetActive(true);
        Faniochoice.SetActive(true);
        Cherentellchoice.SetActive(true);

        if (PlayerPrefs.GetString("Selected") =="hitbox ketsu")
        {
            print("ketsu gehealed");
        }
    }

  public void time()
    {
        if (timer> 0)
        {
            timer -= Time.deltaTime;
        }
        else if (timer==0|| timer < 0)
        {
            timer = 0;
            NextAttck.text = "Choose your next move:";
            Cost.text = "";
            NextAttck.color = new Color(0, 0, 0,30);
        }
       
    }
}
