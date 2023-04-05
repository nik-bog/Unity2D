using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Приветствую тебя, работяга, на угадывателе чисел 2.0 (ну и название xD)");
        Debug.Log("Загадай любое число");
        Debug.Log("Но самое большое число, которое ты можешь загадать: " + max);
        Debug.Log("А самое маленькое: " + min);
        Debug.Log("Нажми стрелку вверх на клавиатуре, если число выше " + guess);
        Debug.Log("Нажми стрелку вниз на клавиатуре, если число ниже " + guess);
        Debug.Log("Нажми Enter, если я угадал твое число");
        max += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter нажат, значит число я угадал, и это " + guess + " УРАААА! :D ");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Число выше или ниже " + guess + "?");
    }
}
