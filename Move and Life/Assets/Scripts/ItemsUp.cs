using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsUp : MonoBehaviour
{
    public GameObject _item;
    public Image _image;
    public GameManager _gm;

    public Health _hp;

    void Update()
    {
        if(_hp._health <10)
        {
            _image.color = Color.red;
            _item.SetActive(true);
        }
    }
    private void OnMouseDown()
    {
        _item.SetActive(false);
        _image.color = Color.green;

        _gm._tasks+=1;
    }
}
