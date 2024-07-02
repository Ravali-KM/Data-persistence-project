using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;

    public TMP_InputField userText;

    public string userName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       //Debug.Log(userText.text);
    }



    private void Awake()
    {
        // start of new code
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        instance = this;
        DontDestroyOnLoad(gameObject);
        
    }
    public void startGame()
    {
        
        SceneManager.LoadScene(1);
        
    }

    public void updateUserName()
    {
        userName = userText.text;
    }
}
