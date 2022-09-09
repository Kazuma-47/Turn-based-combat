using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : AttackInput
{
    
    public void Attack()
    {
        Enemy.currentHP = useTackle(Enemy);
        updateHp.Invoke(Player.currentHP, Enemy.currentHP);

        if (Enemy.currentHP <= 0)
        {
        SceneManager.LoadScene(sceneBuildIndex: 3);
        }
    }

    public void Heal()
    {
         Player.currentHP = useHeal(Player);
         updateHp.Invoke(Player.currentHP, Enemy.currentHP);
    }
}
