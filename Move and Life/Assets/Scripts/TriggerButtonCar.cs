using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerButtonCar : MonoBehaviour
{
    [SerializeField] private GameObject _buttonEngine;
    public GameManager _gm;

    private void OnTriggerEnter(Collider collider)
    {
        if(_gm._tasks > 5)
        {
            if (collider.tag == "Player")
            {
                _buttonEngine.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if(collider.tag=="Player")
        {
            _buttonEngine.SetActive(false);
        }
    }
}
