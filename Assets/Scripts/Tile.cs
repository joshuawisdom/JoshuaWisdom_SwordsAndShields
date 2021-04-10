using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public TileManager tileManager;
    public TileManager.Owner owner;

    public Sprite[] sprites = new Sprite[3];

    void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = sprites[0];
    }

    private void OnMouseUp()
    {
        owner = tileManager.CurrentPlayer;

        if (owner == TileManager.Owner.Sword)
            this.GetComponent<SpriteRenderer>().sprite = sprites[1];
        else if (owner == TileManager.Owner.Shield)
            this.GetComponent<SpriteRenderer>().sprite = sprites[2];

        tileManager.ChangePlayer();
    }
}
