using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quit initiated.");
        Application.Quit();
    }
}