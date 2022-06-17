using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int _spichki = 0;
    public int _bumaga = 0;
    public int _shepki = 0;

    public Text _spichkiText;
    public Text _bumagaText;
    public Text _shepkiText;

    public void CounterUpdate() 
    {
        _spichkiText.text = "" + _spichki;
        _bumagaText.text = "" + _bumaga;
        _shepkiText.text = "" + _shepki;
    }
}
