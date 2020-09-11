﻿using UnityEngine;

public class Tile : MonoBehaviour
{
    Renderer tileRenderer;
    public Material normal;
    public Material hover;
    public Material selected;
    
    public int isPath = 0;
    public bool visited = false;


    private void Start()
    {
        tileRenderer = gameObject.GetComponent<Renderer>();
    }


    private void Update()
    {
        if (isPath == 1)
        {
            tileRenderer.material = normal;
        }
        else
        {
            tileRenderer.material = selected;
        }

        if (visited)
        {
            tileRenderer.material = hover;
        }
    }


    /*
    private void OnMouseEnter()
    {
        if (!isWall)
        {
            tileRenderer.material = hover;
        }
    }

    private void OnMouseExit()
    {
        if (!isWall)
        {
            tileRenderer.material = normal;
        }
        
    }

    private void OnMouseDown()
    {
        isWall = !isWall;
        if (isWall)
        {
            tileRenderer.material = selected;
        }
        else
        {
            tileRenderer.material = normal;
        }
    }
    */

}
