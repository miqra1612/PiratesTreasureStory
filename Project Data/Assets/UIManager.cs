using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameData gameData;

   

    [Header("This area is for all hint and puzzle panel")]
    public Animator clue1;
    public Animator clue2;
    public Animator clue3;
    public Animator clue4;

    [Header("This area is for all correct panel")]
    public Animator correct1;
    public Animator correct2;
    public Animator correct3;
    public Animator correct4;

    [Header("This area is for the puzzle input")]
    public InputField puzzleInput;
    public Text notificationDisplay;
    public InputField puzzleInput2;
    public Text notificationDisplay2;

    [Header("This part is for the puzzle answer, make sure you add the answer for your puzzle")]
    public string puzzleAnswer;
    public string puzzleAnswer2;

    [Header("Check this variable if this is the last puzzle room in the game")]
    public bool lastRoom = false;

    // Start is called before the first frame update
    void Start()
    {
        gameData = GameObject.FindGameObjectWithTag("data").GetComponent<GameData>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckingAnswer1()
    {
        if(puzzleInput.text == puzzleAnswer)
        {
            AnswerCorrect(true);
            SwitchCorrect1(true);
        }
        else
        {
            StartCoroutine(AnswerFalse());
        }
    }

    public void CheckingAnswer2()
    {
        if (puzzleInput2.text == puzzleAnswer2)
        {
            AnswerCorrect(false);
            SwitchCorrect2(true);
        }
        else
        {
            StartCoroutine(AnswerFalse2());
        }
    }

    public void SwitchClue1(bool isActive)
    {
        if (isActive)
        {
            clue1.Play("Window Enter");
        }
        else
        {
            clue1.Play("Window Exit");
        }
    }

    public void SwitchClue2(bool isActive)
    {
        if (isActive)
        {
            clue2.Play("Window Enter");
        }
        else
        {
            clue2.Play("Window Exit");
        }
    }

    public void SwitchClue3(bool isActive)
    {
        if (isActive)
        {
            clue3.Play("Window Enter");
        }
        else
        {
            clue3.Play("Window Exit");
        }
    }

    public void SwitchClue4(bool isActive)
    {
        if (isActive)
        {
            clue4.Play("Window Enter");
        }
        else
        {
            clue4.Play("Window Exit");
        }
    }

    public void AnswerCorrect(bool continueMap)
    {
        if (continueMap && !lastRoom)
        {
            gameData.gamePhase++;
        }

        if (lastRoom)
        {
            gameData.CalculateFinishTime();
        }
        
        clue1.Play("Window Exit");
        clue2.Play("Window Exit");
        clue3.Play("Window Exit");
        clue4.Play("Window Exit");
    }

    IEnumerator AnswerFalse()
    {
        string prev = notificationDisplay.text;

        notificationDisplay.text = "Nothing happen";
        notificationDisplay.color = Color.red;

        yield return new WaitForSeconds(1);
        notificationDisplay.text = prev;
        notificationDisplay.color = Color.black;
    }

    IEnumerator AnswerFalse2()
    {
        string prev = notificationDisplay2.text;

        notificationDisplay2.text = "Nothing happen";
        notificationDisplay2.color = Color.red;

        yield return new WaitForSeconds(1);
        notificationDisplay2.text = prev;
        notificationDisplay2.color = Color.black;
    }

    public void SwitchCorrect1(bool isActive)
    {
        if (isActive)
        {
            correct1.Play("Window Enter");
        }
        else
        {
            correct1.Play("Window Exit");
        }
    }

    public void SwitchCorrect2(bool isActive)
    {
        if (isActive)
        {
            correct2.Play("Window Enter");
        }
        else
        {
            correct2.Play("Window Exit");
        }
    }

    public void SwitchCorrect3(bool isActive)
    {
        if (isActive)
        {
            correct3.Play("Window Enter");
        }
        else
        {
            correct3.Play("Window Exit");
        }
    }

    public void SwitchCorrect4(bool isActive)
    {
        if (isActive)
        {
            correct4.Play("Window Enter");
        }
        else
        {
            correct4.Play("Window Exit");
        }
    }
    
}
