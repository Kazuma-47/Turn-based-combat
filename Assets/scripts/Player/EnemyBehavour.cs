using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyBehavour : MonoBehaviour
{
    public int num;
    public string move;
    public int moveSelection()
    {
        int nummer = Random.Range(1, 9);
        return nummer;
    }
    public void moveActivation()
    {
        num = moveSelection();

        switch (num)
        {
            case 1:
                move = "single target";
                break;
            case 2:
                move = "single target";
                break;
            case 3:
                move = "single target";
                break;
            case 4:
                move = "single target";
                break;
            case 5:
                move = "all targets";
                break;
            case 6:
                move = "all targets";
                break;
            case 7:
                move = "spike shield";
                break;
            case 8:
                move = "spike shield";
                break;
            case 9:
                move = "spike shield";
                break;
            default:
                print("no move was selected");
                break;
        }
    }
}