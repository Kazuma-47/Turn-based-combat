using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioComponent;

    public float GetVolume()
    {
        return audioComponent.volume;
    }
    public void SetVolume(float volume)
    {
        audioComponent.volume = volume;
    }
    void Update()
    {
        
    }
}
