using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _joystick;
    [SerializeField] private GameObject _panelRestart;
    [SerializeField] private GameObject _player;

    [SerializeField] private GameObject _keySlider;
    [SerializeField] private GameObject _fuelSlider;
    [SerializeField] private GameObject _writingSlider;

    public Vector3 _startPosition;

    public MovePlayer _movePlayer;
    public Health _hp;

    public int _task = 0;

    public void TaskCounter()
    {

    }

    public void Restart()
    {
        _hp._health = 100f;
        _movePlayer.Restart();
        _player.transform.position = _startPosition;
        RestartUi();
    }
    public void RestartUi()
    {
        _joystick.SetActive(true);
        _panelRestart.SetActive(false);
        
    }
}
