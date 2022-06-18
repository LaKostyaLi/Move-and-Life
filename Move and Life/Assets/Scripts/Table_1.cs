using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table_1 : MonoBehaviour
{
    public GameObject _kraft;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            _kraft.SetActive(true);
           // Debug.Log("12");
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
