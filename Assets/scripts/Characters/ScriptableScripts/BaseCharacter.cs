using UnityEngine;

public class BaseCharacter : ScriptableObject
{
    #region Variables
    [SerializeField] protected float factor = 1.024f;
    [SerializeField] private string characterName;
    [SerializeField] private int ad;
    [SerializeField] private float baseHealth;

    public Sprite sprite;
    public Move[] moves = new Move[3];
    public int maxHp, currentHp;
    public int currentAttackDamage;
    public float level;
    #endregion

    #region Functions
    public void Stats()
    {
        maxHp = (int)Mathf.Floor(Mathf.Pow(factor,level)*baseHealth);
        currentHp = maxHp;
        currentAttackDamage = (int)Mathf.Floor(Mathf.Pow(factor, level) * ad);
    }

    public void SetMoveUsage()
    {
        foreach (var _move in moves)
        {
            if (_move == null)
            {
                continue;
            }
            _move.usageLeft = _move.Usage;
        }
    }
    //heals an entity for a amount of healing. it will cap its current health if its higher than its max health
    public void Heal(int _amount)
    {
        currentHp += _amount;
        if (currentHp > maxHp) currentHp = maxHp;
    }

    public void TakeDamage(int _amount)
    {
        currentHp -= _amount;
        if (currentHp < 0f) currentHp = 0;
    }
    #endregion

    
}