
using UnityEngine;
using UnityEngine.UI;


public class CharacterLoader : MonoBehaviour
{
    #region Declarations
    [HideInInspector] 
    public enum Entity
    {
        enemy, 
        player
    }

    public Entity entity;
    public Enemie _enemieInfo;
    public  Players _playerInfo;
    private SpriteRenderer _sprite;
    [SerializeField]
    private GameObject HealthBar;
    private Slider bar;
    #endregion
    
    #region Start/Update functions
    private void Start()
    {
        switch (entity)
        {
            case Entity.enemy:
                LoadSkin(_enemieInfo.sprite);
                HealthBar.SetActive(true);
                SetHealthbar();
                    
                break;

            case Entity.player:
                LoadSkin(_playerInfo.sprite);
                SetHealthbar();
                break;
        }
        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        Vector2 newSize = collider.gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size;
        collider.size = newSize;   
    }
    #endregion
    
    #region Load Character
    private void LoadSkin(Sprite skin)
    {
        _sprite = GetComponent<SpriteRenderer>();
        _sprite.sprite = skin;
    }

    private void SetHealthbar()
    {
        switch (entity)
        {
            case Entity.enemy:
                    bar = HealthBar.GetComponent<Slider>();
                    bar.maxValue = _enemieInfo.maxHp;
                    bar.value = _enemieInfo.currentHp;
                break;

            case Entity.player:
                   HealthBar = GameObject.FindWithTag("Healthbar");
                   bar = HealthBar.GetComponent<Slider>();
                   bar.maxValue = _playerInfo.maxHp;
                   bar.value = _playerInfo.currentHp;
                break;
        }
    }

    public void UpdateCurrenthealth()
    {
        switch (entity)
        {
            case Entity.enemy:
                bar.value = _enemieInfo.currentHp;
                break;

            case Entity.player:
                bar.value = _playerInfo.currentHp;
                break;
        }
    }
    #endregion
}
