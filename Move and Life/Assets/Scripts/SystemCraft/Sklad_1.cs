using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sklad_1 : MonoBehaviour
{
    public int _fire1_OnSklad;
    public Text _skladFire1;

    public Craft _craft;
    public Counter _counter;

    public void CounterSkladUpdate()
    {
        _skladFire1.text = "" + _fire1_OnSklad;
    }
}
