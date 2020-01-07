using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    int lowest;

    [SerializeField]
    int highest;

    [SerializeField]
    TextMeshProUGUI guessValue;

    int guess;

    void Start()
    {
        NextGuess();
        PrintGuess();
        highest += 1;
    }

    public void OnPressLower()
    {
        highest = guess - 1;
        NextGuess();
        PrintGuess();
    }

    public void OnPressHigher()
    {
        lowest = guess + 1;
        NextGuess();
        PrintGuess();
    }

    private void NextGuess()
    {
        
        guess = UnityEngine.Random.Range(lowest, highest + 1);
    }

    public void PrintGuess()
    {
        guessValue.text = guess.ToString();
    }
}
