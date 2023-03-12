using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private float movement_speed = 5;
    private Vector2 movement_direction;
    [SerializeField]private Rigidbody2D player_rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
        Movement();
    }

    void Inputs() 
    {
        movement_direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    void Movement() 
    {
        player_rigidbody.velocity = new Vector2(movement_direction.x * movement_speed, movement_direction.y * movement_speed);
    }
}
