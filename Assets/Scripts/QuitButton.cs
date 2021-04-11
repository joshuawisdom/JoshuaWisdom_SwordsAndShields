// Joshua Wisdom
// 2313991
// CPSC 236-03
// jowisdom@chapman.edu
// Project 06: Swords and Shields
// This is my own work, and I did not cheat on this assignment.

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