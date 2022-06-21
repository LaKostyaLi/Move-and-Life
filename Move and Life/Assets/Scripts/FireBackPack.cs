﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBackPack : MonoBehaviour
{
    public Sklad_1 _sklad_1;
    public Text _fire1_onBack;
    public Counter _counter;

    public int _fire_1onBack;

    public void CounterBackPackUpdate()
    {
        _fire1_onBack.text ="" + _fire_1onBack;
    }

    public void OnMouseDown()
    {
        if(_sklad_1._fire1_OnSklad > 0)
        {
            _sklad_1._fire1_OnSklad -= 1;
            _counter._fire_1 -= 1;
            _fire_1onBack += 1;

            _sklad_1.CounterSkladUpdate();
            _counter.CounterUpdate();
            CounterBackPackUpdate();
        }
        else
        {
            Debug.Log("На складе №1 нет огня 1 уровня");
            _fire_1onBack = _fire_1onBack;
        }
    }
}
