using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    //resource
    public int _spichki = 0;
    public int _bumaga = 0;
    public int _shepki = 0;
    //lvl fire
    public int _fire_1 = 0;
    public int _fire_2 = 0;
    public int _fire_3 = 0;

    public Text _spichkiText;
    public Text _bumagaText;
    public Text _shepkiText;

    public Text _fire_1Text;
    public Text _fire_2Text;
    public Text _fire_3Text;

    public void CounterUpdate() 
    {
        _spichkiText.text = "" + _spichki;
        _bumagaText.text = "" + _bumaga;
        _shepkiText.text = "" + _shepki;

        _fire_1Text.text = "" + _fire_1;
        _fire_2Text.text = "" + _fire_2;
        _fire_3Text.text = "" + _fire_3;

        if(_spichki> 2)
        {

        }
        if (_bumaga > 2)
        {

        }
        if (_shepki > 2)
        {

        }
    }
}
