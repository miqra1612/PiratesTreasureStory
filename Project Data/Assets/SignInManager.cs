using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignInManager : MonoBehaviour
{

    public InputField signInPassword;
    public InputField teamName;
    public GameObject signInPanel;
    public GameObject failText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SignIn()
    {
        if(signInPassword.text != "")
        {
            GameData.instance.teamName = teamName.text;
            signInPanel.SetActive(false);
        }
        else
        {
            failText.SetActive(true);
            StartCoroutine(LogInFail());
        }
       
    }

    IEnumerator LogInFail()
    {
        yield return new WaitForSeconds(10);
        failText.SetActive(false);
    }
}
