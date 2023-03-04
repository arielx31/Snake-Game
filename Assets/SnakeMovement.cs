using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    private Vector2 direction = Vector2.right;
    

        
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Vector2.right;
        }
    
    }

    private void FixedUpdate()
    {
        this.transform.position = new Vector3(
                Mathf.Round(this.transform.position.x) + direction.x,
                Mathf.Round(this.transform.position.y) + direction.y,
                0.0f
            );
        
            
    }
}
