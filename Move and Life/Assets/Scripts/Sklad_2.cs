using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sklad_2 : MonoBehaviour
{
    public int _fire1_OnSklad2;

    public Text _skladFire1;
    public Text _fireOnBack;

    public FireBackPack _fireBackPack;
    public Craft _craft;
    public Counter _counter;

    public void CounterSklad2Update()
    {
        _skladFire1.text = "" + _fire1_OnSklad2;
    }

    public void OnMouseDown()
    {
        if(_fireBackPack._fire_1onBack > 0)
        {
            _fireBackPack._fire_1onBack -= 1;
            _fire1_OnSklad2 += 1;
           
            _fireBackPack.CounterBackPackUpdate();

            CounterSklad2Update();
        }
       
        else
        {
            _fire1_OnSklad2 = _fire1_OnSklad2;
            _fireOnBack.text = "В инвентаре нет огня 1 уровня";

            StartCoroutine(TimeToItem());
        }
    }

    IEnumerator TimeToItem()
    {
        yield return new WaitForSeconds(2f);
        _fireOnBack.text = "";
    }
}
