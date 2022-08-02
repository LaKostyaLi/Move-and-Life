using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaValue : MonoBehaviour
{
    public GameObject _startPanel;

    private void Start()
    {
        _startPanel.SetActive(true);
    }
    public void OnButtonClick()
    {
        _startPanel.SetActive(false);
    }
}
 

