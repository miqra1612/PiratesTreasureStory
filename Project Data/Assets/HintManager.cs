using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Room
{
    Room1,
    Room2,
    Room3,
    Room4,
    Room5,
}

public class HintManager : MonoBehaviour
{
    [Header("This area is for clue panel")]
    public Animator cluePanel;
    public Animator clueWarning;
    public bool clueOpen = false;
    public Room room;
    public GameData gameData;

    // Start is called before the first frame update
    void Start()
    {
        gameData = GameObject.FindGameObjectWithTag("data").GetComponent<GameData>();
        CheckingRoom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckingRoom()
    {
        if(room == Room.Room1)
        {
            clueOpen = gameData.clue1Open;
        }
        else if (room == Room.Room2)
        {
            clueOpen = gameData.clue2Open;
        }
        else if (room == Room.Room3)
        {
            clueOpen = gameData.clue3Open;
        }
        else if (room == Room.Room4)
        {
            clueOpen = gameData.clue4Open;
        }
        else if (room == Room.Room5)
        {
            clueOpen = gameData.clue5Open;
        }
    }

    void SaveClueStatus()
    {
        if (room == Room.Room1)
        {
            gameData.clue1Open = clueOpen;
        }
        else if (room == Room.Room2)
        {
            gameData.clue2Open = clueOpen;
        }
        else if (room == Room.Room3)
        {
            gameData.clue3Open = clueOpen;
        }
        else if (room == Room.Room4)
        {
           gameData.clue4Open = clueOpen;
        }
        else if (room == Room.Room5)
        {
           gameData.clue5Open = clueOpen;
        }
    }

    public void OpenWarningPanel()
    {
        if (clueOpen)
        {
            cluePanel.Play("Window Enter");
        }
        else
        {
            clueWarning.Play("Window Enter");
        }
    }

    public void OpenClue()
    {
        gameData.AddTime();
        clueWarning.Play("Window Exit");
        cluePanel.Play("Window Enter");
        clueOpen = true;
        SaveClueStatus();
    }

    public void CloseHint()
    {
        cluePanel.Play("Window Exit");
    }

    public void CloseWarning()
    {
        clueWarning.Play("Window Exit");
    }

}
