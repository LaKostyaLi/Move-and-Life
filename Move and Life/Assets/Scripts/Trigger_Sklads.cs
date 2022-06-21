using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Sklads : MonoBehaviour
{
    public GameObject _sklad_1;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            _sklad_1.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _sklad_1.SetActive(false);
        }
    }
}
