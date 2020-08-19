using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public Tile currentTile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(Tile t)
    {
        if(currentTile)
        {
            currentTile.RemoveUnit();
        }

        currentTile = t;
        currentTile.SetUnit(this);
    }
}
