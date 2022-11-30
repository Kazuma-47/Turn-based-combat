
using System;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

public class EffectManager : MonoBehaviour
{
    [SerializeField] private UnityEvent onParticleEnd = new UnityEvent();
     
    
    
    public void PlayEffect(GameObject Effect, Transform Pos)
    {
        var currentEffect = Instantiate(Effect, Pos.position, quaternion.identity, gameObject.transform);
        var _moveEffectmain = currentEffect.GetComponent<ParticleSystem>().main;
        _moveEffectmain.stopAction = ParticleSystemStopAction.Callback;

    }
    
    public void OnParticleEnd()
    {
        onParticleEnd.Invoke();
    }
}
