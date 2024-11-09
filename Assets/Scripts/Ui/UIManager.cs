using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoretext;
    private int Score = 0;

    private void Awake()
    {
        _scoretext = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        RefreshUi();
    }
    public void IncreaseScore(int increment)
    {
       Score += increment;
        RefreshUi();
    }

    public void RefreshUi()
    {
        _scoretext.text = "Score : " + Score;

    }
}
