using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public Slider slider;
    private void Update()
    {
        var _player = GameObject.FindWithTag("Player").GetComponent<CreatePlayer>();
        slider.maxValue = _player._player.maxHp;
        slider.value = _player._player.currentHp;
    }
}
