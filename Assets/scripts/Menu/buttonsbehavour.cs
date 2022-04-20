using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class buttonsbehavour : MonoBehaviour
{
    public TurnManager TM;
    public TextMeshProUGUI Cost;

    void OnMouseOver()
    {
        if(this.gameObject.name== "atack 1")
        {
            button1();
        }
        else if(this.gameObject.name== "atack 2"){
            button2();
        }
        else if(this.gameObject.name== "atack 3")
        {
            button3();
        }  
        
    }

    public void button1()
    {
        switch (TM.Attack1.text)
        {
            case "Silent slash":
                TM.timer = 0.01f;
                TM.NextAttck.text = "Discription:                       A fast slash that has no sound.";
                Cost.text = "Damage: 50                             Stamina: 20";
                break;
        }
    }


    public void button2()
    {
        switch (TM.Attack2.text)
        {
            case "Darkness cutter":
                TM.timer = 0.01f;
                TM.NextAttck.text = "Discription:                  A slice imbued with light";
                Cost.text = "Damage: 50                             Stamina: 20";
                break;
        }
    }

    public void button3()
    {
        switch (TM.Attack3.text)
        {
            case "Retsoku":
                TM.timer = 0.01f;
                TM.NextAttck.text = "Discription:                  signature move to kill ";
                Cost.text = "Damage: 50                             Stamina: 20";
                break;
        }
    }
}
