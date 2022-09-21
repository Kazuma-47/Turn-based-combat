using UnityEngine;


[CreateAssetMenu(fileName ="Character Name" , menuName = "character stats")]
public class CreatePlayer : ScriptableObject
{
    public string names;
    public int baseHp;
    public int lvl;
    public bool Monster;
    public float HpScale = 1.025f;

    public int[] MoveIds = new int[4];

}
