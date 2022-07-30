using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animation;

    [SerializeField] private float _moveSpeed;

    public Sound _sound;


    private void FixedUpdate()
    {
        _rb.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rb.velocity.y, _joystick.Vertical * _moveSpeed);

        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rb.velocity);
            _animation.SetBool("isRunning", true);
        }
        else
        { 
            _animation.SetBool("isRunning", false);
        }
    }

    public void Death()
    {
        _animation.Play("Die");
    }

    public void Restart()
    {
        _animation.Play("Idle");
    }
}
