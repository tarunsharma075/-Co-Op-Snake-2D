using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class GameManager : MonoBehaviour
{
    [SerializeField] private Button _clickedbutton;
    [SerializeField]private GameObject NextSencne;

    private void Start()
    {
        _clickedbutton = GetComponent<Button>();
        _clickedbutton.onClick.AddListener(OnClick);
    }


    private void OnClick()
    {

        NextSencne.SetActive(true);
    }

}
