using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour
{

    public void Play()
    {
        PlayerPrefs.SetInt("Ketsuhealth",100);
        PlayerPrefs.SetInt("47health",150);
        PlayerPrefs.SetInt("Biahealth",100);
        PlayerPrefs.SetInt("kEVINhealth", 150);
        PlayerPrefs.SetInt("RosalinaHealth",100);
        

        PlayerPrefs.SetInt("KetsuStamina", 100);
        PlayerPrefs.SetInt("47Stamina", 100);
        PlayerPrefs.SetInt("BiaMana", 100);
        PlayerPrefs.SetInt("kEVINStamina", 100);
        PlayerPrefs.SetInt("RosalinaStamina", 100);


        PlayerPrefs.SetInt("EnemyHealth", 3000);

        SceneManager.LoadScene("battle screen");
    }
}
