using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent (typeof (NavMeshAgent))] //автоматически добавит НавМеш на объект на котором висит скрипт
public class Enemy : MonoBehaviour
{
    public Transform _target;
    public float distance;

    NavMeshAgent _myAgent;
    Animator _animator;

    [SerializeField] private Health _hpPlayer;
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _myAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        distance = Vector3.Distance(_target.position, transform.position);

        if(distance > 40)
        {
            _myAgent.enabled = false; //отключаем агента
            _animator.Play("IdleZ");
        }

        if (distance <= 40 & distance > 5)
        {
            _myAgent.enabled = true;
            _myAgent.SetDestination(_target.position);
            _animator.Play("RunZ");
        }

        if (distance <= 5 & _hpPlayer._health > 0) 
        {
            _myAgent.enabled = false;
            
            _animator.Play("AtackZ");
        }

        if(_hpPlayer._health == 0)
        {
            _myAgent.enabled = true;
            _animator.Play("IdleZ");
        }
    }
}
