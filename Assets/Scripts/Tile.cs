// Joshua Wisdom
// 2313991
// CPSC 236-03
// jowisdom@chapman.edu
// Project 06: Swords and Shields
// This is my own work, and I did not cheat on this assignment.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public TileManager tileManager;
    public TileManager.Owner owner;

    public AudioClip swordUnsheath;
    public AudioClip shieldHit;

    public Sprite[] sprites = new Sprite[3];

    void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = sprites[0];
    }

    private void OnMouseUp()
    {
        owner = tileManager.CurrentPlayer;

        if (owner == TileManager.Owner.Sword)
        {
            this.GetComponent<SpriteRenderer>().sprite = sprites[1];
            AudioSource.PlayClipAtPoint(swordUnsheath, transform.position);
        }
        else if (owner == TileManager.Owner.Shield)
        {
            this.GetComponent<SpriteRenderer>().sprite = sprites[2];
            AudioSource.PlayClipAtPoint(shieldHit, transform.position);
        }

        tileManager.ChangePlayer();
    }
}
