using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public float _health = 100f;
    [SerializeField] private GameObject _joystick;
    [SerializeField] private GameObject _buttonRestart;

    [SerializeField] private Slider _slider;

    public Image _image;
    public MovePlayer _movePlayer;
  
    private void Update()
    {
        _slider.value = _health;

        if(_health <10f)
        {
            _image.enabled = false;
        }
        else
        {
            _image.enabled = true;
        }

        if (_health == 0)
        {
            _movePlayer.Death();
            DieUi();
        }
    }
    void DieUi()
    {
        _joystick.SetActive(false);
        _buttonRestart.SetActive(true);
    }
}
