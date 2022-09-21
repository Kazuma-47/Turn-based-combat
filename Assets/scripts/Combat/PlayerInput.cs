using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Player
{
    public class PlayerInput : AttackInput
    {

        public void Attack()
        {
            Enemy.currentHP = useTackle(Enemy);
            //update healhbar enemy

            if (Enemy.currentHP <= 0)
            {
                SceneManager.LoadScene(sceneBuildIndex: 3);
            }
        }

        public void Heal()
        {
            Player.currentHP = useHeal(Player);
            //update healhbar player
        }
    }

}
