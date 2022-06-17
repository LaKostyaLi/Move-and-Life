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
            _counter._spichki += 1;
        }

        if (_itemType == ItemType.bumaga)
        {
            _counter._bumaga += 1;
        }

        if (_itemType == ItemType.shepki)
        {
            _counter._shepki += 1;
        }

        _counter.CounterUpdate();
        Destroy(gameObject);
    }
}
