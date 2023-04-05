using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText;
    [SerializeField] Button higherButton;
    [SerializeField] Button lowerButton;

    int guess;

    private void Start()
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

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
        CheckRange();
    }

    void CheckRange()
    {
        if (guessText.text == "1")
        {
            lowerButton.interactable = false;
        }

        else if (guessText.text == "1000")
        {
            higherButton.interactable = false;
        }

        else
        {
            higherButton.interactable = true;
            lowerButton.interactable = true;
        }
    }
}
