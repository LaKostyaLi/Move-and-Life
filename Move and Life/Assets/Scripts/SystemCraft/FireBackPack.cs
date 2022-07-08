using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBackPack : MonoBehaviour
{
    public Sklad_1 _sklad_1;
    public Text _fire1_onBack;
    public Counter _counter;

    public Text _fireToSklad1;
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
            _fireToSklad1.text = "На складе №1 нет огня 1 уровня";
            StartCoroutine(TimeToItem());
            _fire_1onBack = _fire_1onBack;
        }
    }

    IEnumerator TimeToItem()
    {
        yield return new WaitForSeconds(2f);
        _fireToSklad1.text = "";
    }
}
