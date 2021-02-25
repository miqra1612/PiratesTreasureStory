using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameData gameData;
    public GameObject[] hiddenMapButtons;

    // Start is called before the first frame update
    void Start()
    {
        gameData = GameObject.FindGameObjectWithTag("data").GetComponent<GameData>();

        OpenNextArea();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OpenNextArea()
    {
       

        for(int i = 0; i < gameData.gamePhase;i++)
        {
            hiddenMapButtons[i].SetActive(true);
        }
    }
}
