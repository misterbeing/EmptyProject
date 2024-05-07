using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody thisPlayer;
    [Range(0,1)]
    public float moveSpeed;

    private void Start()
    {
        thisPlayer = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        ContnuesPlayerMovement();
    }
    void ContnuesPlayerMovement()
    {
        float leftRightMovemnt = Input.GetAxis("Vertical");
        float movement = Input.GetAxis("Horizontal");
         Vector3 move = new Vector3(1f,0f,movement)*moveSpeed;
        thisPlayer.MovePosition(transform.position+ move);
    }
}
