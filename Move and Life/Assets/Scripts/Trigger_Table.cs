using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Table : MonoBehaviour
{
    public GameObject _kraft;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            _kraft.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            _kraft.SetActive(false);
        }
    }
}
