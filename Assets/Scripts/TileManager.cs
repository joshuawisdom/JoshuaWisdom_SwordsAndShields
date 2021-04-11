using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileManager : MonoBehaviour
{
    public Owner CurrentPlayer;
    public Tile[] Tiles = new Tile[9];

    public enum Owner
    {
        None,
        Sword,
        Shield
    }

    public Text swordsScoreDisplay;
    public Text shieldsScoreDisplay;

    public Button resetButton;
    public Button quitButton;

    public Sprite blankSquare;

    private int swordScore = 0;
    private int shieldScore = 0;

    private bool won;

    // Start is called before the first frame update
    void Start()
    {
        won = false;
        resetButton.gameObject.SetActive(false);
        CurrentPlayer = Owner.Sword;

        swordsScoreDisplay.text = "Sword: " + swordScore;
        shieldsScoreDisplay.text = "Shield: " + shieldScore;
    }

    public void ChangePlayer()
    {
        if (CheckForWinner())
            return;

        if (CurrentPlayer == Owner.Sword)
            CurrentPlayer = Owner.Shield;
        else
            CurrentPlayer = Owner.Sword;
    }

    public bool CheckForWinner()
    {
        if (Tiles[0].owner == CurrentPlayer && Tiles[1].owner == CurrentPlayer && Tiles[2].owner == CurrentPlayer)
            won = true;
        else if (Tiles[3].owner == CurrentPlayer && Tiles[4].owner == CurrentPlayer && Tiles[5].owner == CurrentPlayer)
            won = true;
        else if (Tiles[6].owner == CurrentPlayer && Tiles[7].owner == CurrentPlayer && Tiles[9].owner == CurrentPlayer)
            won = true;
        else if (Tiles[0].owner == CurrentPlayer && Tiles[3].owner == CurrentPlayer && Tiles[6].owner == CurrentPlayer)
            won = true;
        else if (Tiles[1].owner == CurrentPlayer && Tiles[4].owner == CurrentPlayer && Tiles[7].owner == CurrentPlayer)
            won = true;
        else if (Tiles[2].owner == CurrentPlayer && Tiles[5].owner == CurrentPlayer && Tiles[8].owner == CurrentPlayer)
            won = true;
        else if (Tiles[0].owner == CurrentPlayer && Tiles[4].owner == CurrentPlayer && Tiles[8].owner == CurrentPlayer)
            won = true;
        else if (Tiles[2].owner == CurrentPlayer && Tiles[4].owner == CurrentPlayer && Tiles[6].owner == CurrentPlayer)
            won = true;

        if (won)
        {
            ShowButtons();
            UpdateScore();
            won = false;

            return true;
        }

        return false;
    }

    private void UpdateScore()
    {
        if (won)
            if (CurrentPlayer == Owner.Sword)
            {
                swordScore++;
            }
            else
            {
                shieldScore++;
            }

        swordsScoreDisplay.text = "Swords: " + swordScore;
        shieldsScoreDisplay.text = "Shield: " + shieldScore;

        Debug.Log("Winner: " + CurrentPlayer);
    }

    private void ShowButtons()
    {
        resetButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
    }

    public void ResetGame()
    {
        for (int i = 0; i < 9; i++)
        {
            Tiles[i].GetComponent<SpriteRenderer>().sprite = blankSquare;
            Tiles[i].owner = Owner.None;
        }

        won = false;

        Debug.Log("Reset initiated.");
        resetButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);
    }


}
