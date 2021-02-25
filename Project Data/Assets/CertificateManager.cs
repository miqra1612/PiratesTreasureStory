using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CertificateManager : MonoBehaviour
{
    public Text teamName;
    public Text timer;
    public GameData gameData;

    // Start is called before the first frame update
    void Start()
    {
        gameData = GameObject.FindGameObjectWithTag("data").GetComponent<GameData>();
        ShowCertificate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowCertificate()
    {
        teamName.text = ": " + gameData.teamName;
        DateTime ts = DateTime.Parse(gameData.startTime);
        DateTime te = DateTime.Parse(gameData.endTime);
        timer.text = ": " + DateTime.Compare(te, ts) + " Minute";
    }
}
