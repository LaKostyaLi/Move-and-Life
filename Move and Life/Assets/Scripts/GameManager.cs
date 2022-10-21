using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _joystick;
    [SerializeField] private GameObject _panelRestart;
    [SerializeField] private GameObject _player;

    [SerializeField] private GameObject _finishText;
 
    public Vector3 _startPosition;
    public Vector3 _finishPoisiton;

    public MovePlayer _movePlayer;
    public Health _hp;

    public int _tasks;

    private void Start()
    {
        _tasks = 0;     
    }
    private void Update()
    {
        TaskCounter();
    }
    private void TaskCounter()
    {
        if(_tasks > 5)
        {
            _finishText.SetActive(true);
        }
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
        _finishText.SetActive(false);
        _tasks = 0;
    }

    public void PlayerFinishPosition()
    {
        _player.transform.position = _finishPoisiton;
    }
}
