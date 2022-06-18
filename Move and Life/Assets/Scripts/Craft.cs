using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craft : MonoBehaviour
{
    public int _craftItemNumber=0;
    public Counter _counter;

    private bool task1_1 = true;
    private bool task1_2 = true;
    private bool task1_3 = true;

    private bool task2_1 = true;
    private bool task2_2 = true;

    private bool task3_1 = true;
    private bool task3_2 = true;

    public void CraftItemUpdate(int _myNumber)
    {
        _craftItemNumber = _myNumber;
        print(_craftItemNumber);
    }

    public void Update()
    {
        if(Input.GetKeyDown (KeyCode.E))
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
        if(_counter._spichki < 1)
        {
            task1_1 = false;
            Debug.Log("Не хватает спичек");
        }
        else
        {
            task1_1 = true;
        }

        if(_counter._bumaga < 1)
        {
            task1_2 = false;
            Debug.Log("Не хватает бумаги");
        }
        else
        {
            task1_2 = true;
        }

        if(_counter._shepki < 1)
        {
            task1_3 = false;
            Debug.Log("Не хватает щепок");
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
            _craftItemNumber = 0;
        }
    }

    public void Fire2()
    {
        if(_counter._fire_1 < 2)
        {
            task2_1 = false;
            Debug.Log("Не хватает огня уровня 1");
        }

        else
        {
            task2_1 = true;
        }


        if (task2_1 == true)
        {
            _counter._fire_1 -= 2;
            _counter._fire_2 += 1;
            _counter.CounterUpdate();
            _craftItemNumber = 0;
        }
    }

    public void Fire3()
    {
        if (_counter._fire_1 < 1)
        {
            Debug.Log("Не хватает огня уровня 1");
            task3_1 = false;
        }
        else
        {
            task3_1 = true;
        }

        if (_counter._fire_2 < 1)
        {
            Debug.Log("Не хватает огня уровня 2");
            task3_2 = false;
        }
        else
        {
            task3_2 = true;
        }

        if (task3_1 == true & task3_2 == true)
        {
            StartCoroutine(TimeFoFire3());
        }
    }   

    IEnumerator TimeFoFire3()
    {
        yield return new WaitForSeconds(5f);

        _counter._fire_1 -= 1;
        _counter._fire_2 -= 1;
        _counter._fire_3 += 1;
        _counter.CounterUpdate();
        _craftItemNumber = 0;
    }
}



   


