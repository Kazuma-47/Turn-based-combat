using System;
using UnityEngine;
using UnityEngine.Events;

public class ParticleEndSignal : MonoBehaviour
{

    public void OnParticleSystemStopped()
    {
        GetComponentInParent<EffectManager>().OnParticleEnd();
        Destroy(gameObject);
    }
}
