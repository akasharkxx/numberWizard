using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max, min, guess;
    public int maxGuess = 5;
    public Text text;
    void Start(){
        StartGame();
    }
    void StartGame() {
        min = 1;
        max = 1000;
        guess = 500;
        max = max + 1;
    }
    public void GuessLower(){
        max = guess;
        nextGuess();
    }
    public void GuessHigher(){
        min = guess;
        nextGuess();        
    }
    void nextGuess(){
        guess = Random.Range(max, min);
        text.text = guess.ToString();
        maxGuess--;
        if(maxGuess <= 0){
            Application.LoadLevel("Win");
        }
    }
}
