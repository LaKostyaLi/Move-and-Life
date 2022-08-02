using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform _target1;
    public Transform _target2;

    public Vector3 _positionCamera;
    private float _cameraSpeed = 1.5f;

    private bool _inCar = false;

    private void FixedUpdate()
    {
        if(_inCar == false)
        {
            Vector3 Position = _target1.position + _positionCamera;

            Vector3 currentPosiiton = Vector3.Lerp(transform.position, Position, _cameraSpeed * Time.deltaTime);
            transform.position = currentPosiiton;

            transform.LookAt(_target1);
        }
        else
        {
            Vector3 Position = _target2.position + _positionCamera;

            Vector3 currentPosiiton = Vector3.Lerp(transform.position, Position, _cameraSpeed * Time.deltaTime);
            transform.position = currentPosiiton;

            transform.LookAt(_target2);
        }
    
    }

    public void OnMouseDown()
    {
        _inCar = true;
    }
}
