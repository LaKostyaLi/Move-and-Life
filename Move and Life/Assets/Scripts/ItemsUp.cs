using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsUp : MonoBehaviour
{
    public GameObject _key;

    private void OnMouseDown()
    {
        _key.SetActive(false);
    }
}
