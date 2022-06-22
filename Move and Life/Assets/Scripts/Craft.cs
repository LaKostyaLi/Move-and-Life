using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Craft : MonoBehaviour
{
    public int _craftItemNumber=0;
    public Counter _counter;
    public Sklad_1 _sklad1;
    public Sklad_2 _sklad2;

    public Text _spichki;
    public Text _bumaga;
    public Text _shepki;

    public Text _fire1;
    public Text _fire2;


    private bool task1_1 = true;
    private bool task1_2 = true;
    private bool task1_3 = true;

    private bool task2_1 = true;
    private bool task2_2 = true;

    private bool task3_1 = true;


    public void CraftItemUpdate(int _myNumber)
    {
        _craftItemNumber = _myNumber;
        print(_craftItemNumber);
    }

    public void Update()
    {
        if (Input.GetKeyDown (KeyCode.E))
        {
            if(_craftItemNumber ==1)
            {
                Fire1();
            }

            if (_craftItemNumber == 2)
            {
                Fire2();
            }

            if (_craftItemNumber == 3)
            {
                Fire3();
            }
        }
    }

    public void Fire1()
    {
        if (_counter._spichki < 1)
        {
            task1_1 = false;
            _spichki.text = "Не хватает спичек";
            StartCoroutine(TimeFoItem());
        }
        else
        {
            task1_1 = true;
        }

        if(_counter._bumaga < 1)
        {
            task1_2 = false;
            _bumaga.text = "Не хватает бумаги";
            StartCoroutine(TimeFoItem());
        }
        else
        {
            task1_2 = true;
        }

        if(_counter._shepki < 1)
        {
            task1_3 = false;
            _shepki.text = "Не хватает щепок";
            StartCoroutine(TimeFoItem());
        }
        else
        {
            task1_3 = true;
        }

        if (task1_1==true & task1_2 == true & task1_3 ==true)
        {
            _counter._spichki -= 1;
            _counter._bumaga -= 1;
            _counter._shepki -= 1;
            _counter._fire_1 += 1;
            _counter.CounterUpdate();

            _sklad1._fire1_OnSklad = _counter._fire_1;
            _sklad1.CounterSkladUpdate();

            _craftItemNumber = 0;
        }
    }

    public void Fire2()
    {
        if (_sklad2._fire1_OnSklad2 < 2)
        {
            task2_1 = false;
            _fire1.text = "Не хватает огня уровня 1";

            StartCoroutine(TimeFoItem());
        }
        else
        {
            task2_1 = true;
        }

        if (task2_1 == true)
        {
            _sklad2._fire1_OnSklad2 -= 2;

            StartCoroutine(TimeToFire2());
            _craftItemNumber = 0;
        }
    }
    public void Fire3()
    {
        if (_counter._fire_2  < 2)
        {
            task3_1 = false;
            _fire2.text = "Не хватает огня уровня 2";

            StartCoroutine(TimeFoItem());
        }
        else
        {
            task3_1 = true;
        }

        if (task3_1 == true)
        {
            _counter._fire_2 -= 2;

            StartCoroutine(TimeToFire3());
            _craftItemNumber = 0;
        }
    }

    IEnumerator TimeFoItem()
    {
        yield return new WaitForSeconds(2f);
        _spichki.text = "";
        _bumaga.text = "";
        _shepki.text = "";

        _fire1.text = "";
        _fire2.text = "";
    }

    IEnumerator TimeToFire2()
    {
        yield return new WaitForSeconds(5f);
        _counter._fire_2 += 1;

        _fire1.text = "";
       _sklad2.CounterSklad2Update();
        _counter.CounterUpdate();
    }

    IEnumerator TimeToFire3()
    {
        yield return new WaitForSeconds(10f);
        _counter._fire_3 += 1;

        _fire2.text = "";
        _counter.CounterUpdate();
    }
}



   


