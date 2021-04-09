using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour
{
    public int min;
    public int max;
    private int guess;

    public Text guessText;
    
    void Start()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    private void NextGuess()
    {
        guess = Random.Range(min, max);
        guessText.text = guess.ToString("D");
    }
}
