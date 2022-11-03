using System;
using UnityEngine;
using Random = UnityEngine.Random;


public class Grass : MonoBehaviour
{
    private EnemiePlacer placer;
    [SerializeField]
    private bool inGrass;
    float steps;
    [SerializeField]
    private Player player;
    private void Start()
    {
        placer = GameObject.Find("placer").GetComponent<EnemiePlacer>();
        player = GameObject.FindWithTag("PlayerUnit").GetComponent<Player>();
    }

    private void Update()
    {   //handles the chances of entering combat and what enemy will spawn
        if(inGrass == true)
        {
            if (player.horizontal != 0 || player.vertical != 0)
            {
                steps += 5 * Time.deltaTime;
            }
            if (steps >= 3)
            {
                steps = 0;
                int _rand = Random.Range(0, 6);
                if (_rand >= 5)
                {
                    placer.Encounter();
                }
            }
        }
    }

    public void SetActivity(bool activity)
    {
        inGrass = activity;
    }
    
}
