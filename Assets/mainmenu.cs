using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject entrypanel;

    // Start is called before the first frame update
    void Start()
    {
        menupanel.SetActive(true);
        entrypanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void EntryButton()
    {
        menupanel.SetActive(false);
        entrypanel.SetActive(true);
    }

    public void BackButton()
    {
        menupanel.SetActive(true);
        entrypanel.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
