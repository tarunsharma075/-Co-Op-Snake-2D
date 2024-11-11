using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoretextforsnakeone;

    [SerializeField] private TextMeshProUGUI _scoretextforsnaketwo;
    private int Scoreforfirstsnake = 0;
    private int Scoreforsecondtsnake = 0;


    private void Awake()
    {
        _scoretextforsnakeone = GetComponent<TextMeshProUGUI>();
        _scoretextforsnaketwo = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        RefreshUi();
        RefreshUiForSecondSnake();
    }
    public void IncreaseScoreforsnakeone(int increment)
    {
       Scoreforfirstsnake += increment;
        RefreshUi();
    }
    public void IncreaseScoreforsnaketwo(int increment)
    {
        Scoreforsecondtsnake += increment;
        RefreshUiForSecondSnake();

    }

    public void RefreshUi()
    {
        _scoretextforsnakeone.text = "Score : " + Scoreforfirstsnake;


    }
    public void RefreshUiForSecondSnake()
    {
        _scoretextforsnaketwo.text = "Score : " + Scoreforsecondtsnake;
        ;


    }

    public void DecreaseScoreForFirstSnake(int lossscore) {

        Scoreforfirstsnake -= lossscore;

        RefreshUi();
        if (Scoreforfirstsnake < 0) { 
        Scoreforfirstsnake= 0;   
            RefreshUi() ;
        
        }
    }
    public void DecreaseScoreForSecondSnake(int lossscore)
    {

        Scoreforsecondtsnake  -= lossscore;

        RefreshUiForSecondSnake();
        if (Scoreforsecondtsnake < 0)
        {
            Scoreforsecondtsnake = 0;
            RefreshUiForSecondSnake();

        }
    }
}
