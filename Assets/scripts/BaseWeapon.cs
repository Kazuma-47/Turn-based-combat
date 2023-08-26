using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapon Config")]
public class BaseWeapon : ScriptableObject
{
    public string Name;
    public float BaseDamage;
    enum StatusEffects
    { Poison , Burn , Slow }
    [SerializeField] StatusEffects StatusEffect;
    enum WeaponTypes
    { Bow , Spell , Sword }
    [SerializeField] WeaponTypes WeaponType;
    public Sprite Sprite;
    public float AttackSpeed;
    public int ComboAmount;
    public float Range;
    public GameObject CollitionParticle;
    public float DamageMultiplier;
    public bool CanBlock;
 
}
