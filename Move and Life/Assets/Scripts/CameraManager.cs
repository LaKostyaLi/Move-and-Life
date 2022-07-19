using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform _target;

    public Vector3 _positionCamera;
    private float _cameraSpeed = 1.5f;

    private void FixedUpdate()
    {
        Vector3 Position = _target.position + _positionCamera;

        Vector3 currentPosiiton = Vector3.Lerp(transform.position, Position, _cameraSpeed * Time.deltaTime); 
        transform.position = currentPosiiton;

        transform.LookAt(_target);
    }
}
