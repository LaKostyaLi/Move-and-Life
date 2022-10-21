using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panels : MonoBehaviour
{
    public GameObject _startPanel;

    public GameObject _finishPanel;

    private void Start()
    {
        _startPanel.SetActive(true);
        _finishPanel.SetActive(false);
    }
    public void OnButtonStartClick()
    {
        _startPanel.SetActive(false);
    }

    public void ShowFinishPanel()
    {
        _finishPanel.SetActive(true);
    }
}
 

