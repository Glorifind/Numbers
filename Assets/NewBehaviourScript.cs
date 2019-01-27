using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int maxNumber = 1000;
    int minNumber = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StrartNewGameDialog();
    }

    void StrartNewGameDialog()
    {
        // Reseting global parameters
        maxNumber = 1000;
        minNumber = 1;
        guess = 500;

        Debug.Log("Welcome!");
        Debug.Log("I will guess your number. Pick a number and don't tell me!");
        Debug.Log("Lowest is: " + minNumber);
        Debug.Log("Highest is: " + maxNumber);
        Debug.Log("Tell me if number is higher or lower than: " + guess);
        Debug.Log("Press Up Key if it's higher, Down Key if lower and Enter if it's correct");

        //Max must be 1 more than player max in case player want to guess maximum number
        maxNumber += 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minNumber = guess;
            NumberGuessed();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxNumber = guess;
            NumberGuessed();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You thought about number: " + guess + ". I will always win! Try me!");
            StrartNewGameDialog();
        }

    }

    void NumberGuessed()
    {
        guess = ((minNumber + maxNumber) / 2);
        Debug.Log("Tell me if number is higher or lower than: " + guess);
    }
}
