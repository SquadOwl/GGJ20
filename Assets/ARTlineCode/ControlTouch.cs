using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTouch : Control
{
    public Rigidbody rb;
    public float playerSpeed;
    public int directionInputVertical;
    public int directionInputHorizontal;
    public bool facingRight = true;

    public ControlTouch(Rigidbody curRb, float curSpeed )
    {
        rb = curRb; 
        playerSpeed = curSpeed;
    }




    //void FixedUpdate()
    //{
    //    rb.velocity = new Vector3(playerSpeed * directionInput, rb.velocity.y);
    //}

    public override void MoveUpdate()
    {

        rb.velocity = new Vector3(playerSpeed * directionInputHorizontal,0, playerSpeed * directionInputVertical);

    }

    //public override void MoveUp(int InputAxis)
    //{
    //    directionInputVertical = InputAxis;
    //}
    //public override void MoveDown(int InputAxis)
    //{
    //    directionInputVertical = InputAxis;
    //}
    //public override void MoveLeft(int InputAxis)
    //{
    //    directionInputHorizontal = InputAxis;
    //}
    //public override void MoveRight(int InputAxis)
    //{
    //    directionInputHorizontal = InputAxis;
    //}

    public override void MoveDiagonal(int InputAxis)
    {

        directionInputHorizontal = InputAxis;

    }

    public override void MoveVertical(int InputAxis)
    {

        directionInputVertical = InputAxis;

    }


    //void Flip()
    //{
    //    facingRight = !facingRight;
    //    Vector3 theScale = transform.localScale;
    //    theScale.x *= -1;
    //    transform.localScale = theScale;
    //}


}

