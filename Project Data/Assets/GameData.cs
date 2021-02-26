using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameData : MonoBehaviour
{
    public int gamePhase = 0;
    public string startTime;
    public string endTime;
    public string teamName;
    public double clueTime;

    [Header("This part is for all clue buttons data")]
    public bool clue1Open = false;
    public bool clue2Open = false;
    public bool clue3Open = false;
    public bool clue4Open = false;
    public bool clue5Open = false;

    public static GameData instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        

        startTime = DateTime.Now.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddTime()
    {
        clueTime += 5;
    }

    public void CalculateFinishTime()
    {
        DateTime df = DateTime.Now;
        DateTime de = df.AddMinutes(clueTime);
        Debug.Log(de);
        endTime = de.ToString();
        
    }
}
