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
}
