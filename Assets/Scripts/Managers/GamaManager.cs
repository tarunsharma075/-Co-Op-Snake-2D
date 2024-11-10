using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GamaManager : MonoBehaviour
{
    [SerializeField] private GameObject _maingameobj;
    [SerializeField] private GameObject _pausemenu;
    [SerializeField] private Button Resume;


    private void OnclickEscape()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){

            _maingameobj.SetActive(false);
            _pausemenu.SetActive(true);
            Resume.onClick.AddListener(ClickAction);

        }
    }

    public void ClickAction()
    {
        _maingameobj.SetActive(true);
        _pausemenu.SetActive(false);
    }

    public void Update()
    {
        OnclickEscape();
    }
}
