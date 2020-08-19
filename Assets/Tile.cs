using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Vector2 pos;
    public double height;
    public Unit occupyingUnit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetUnit(Unit u)
    {
        occupyingUnit = u;
    }

    public void RemoveUnit()
    {
        occupyingUnit = null;
    }
}
