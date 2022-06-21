using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    spichki,
    bumaga,
    shepki
}

public class Items : MonoBehaviour
{
    public ItemType _itemType;
    public Counter _counter;

    private void OnMouseDown()
    {
        if(_itemType == ItemType.spichki)
        {
            if (_counter._spichki == 2)
            {
                _counter._spichki = 2;
                Debug.Log("Лимит 2 еденицы одного итема");
            }
            else
            {
                _counter._spichki += 1;
                Destroy(gameObject);
            }
        }

        if (_itemType == ItemType.bumaga)
        {
            if(_counter._bumaga == 2)
            {
                _counter._bumaga = 2;
                Debug.Log("Лимит 2 еденицы одного итема");
            }
            else
            {
                _counter._bumaga += 1;
                Destroy(gameObject);
            }
        }

        if (_itemType == ItemType.shepki)
        {
            if(_counter._shepki == 2)
            {
                _counter._shepki = 2;
                Debug.Log("Лимит 2 еденицы одного итема");
            }
            else
            {
                _counter._shepki += 1;
                Destroy(gameObject);
            }
        }
        _counter.CounterUpdate();
    }
}
