using System;
using UnityEngine;
using Random = UnityEngine.Random;


public class Grass : MonoBehaviour
{
    #region Variables
    private EnemiePlacer placer;
    private bool inGrass;
    float steps;
    private Player player;
    [SerializeField] private int encounterSteps; // steps per encounter kans
    [SerializeField] private int chance; // kans op encounter
    #endregion

    #region StartUp
    private void Start()
    {
        placer = GameObject.Find("placer").GetComponent<EnemiePlacer>();
        player = GameObject.FindWithTag("PlayerUnit").GetComponent<Player>();
    }

    private void Update()
    {   //reguleerd de kans om een enemie tegen te komen
        if(inGrass == true)
        {
            if (player.horizontal != 0 || player.vertical != 0)
            {
                steps += 5 * Time.deltaTime;
            }
            if (steps >= encounterSteps)
            {
                steps = 0;
                int _rand = Random.Range(0, 100);
                if (_rand >= chance)
                {
                    placer.Encounter();
                }
            }
        }
    }
    #endregion

    #region Functions
    public void SetActivity(bool activity)
    {
        inGrass = activity;
        steps = encounterSteps;
    }
    #endregion
}
