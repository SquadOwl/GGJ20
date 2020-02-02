using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTouch : Control
{
    public Rigidbody rb;
    public Transform tr;
    public float playerSpeed;
    public int directionInputVertical;
    public int directionInputHorizontal;
    public bool facingRight = true;

   

    public ControlTouch(Transform curTr, Rigidbody curRb, float curSpeed )
    {
        tr = curTr;
        rb = curRb; 
        playerSpeed = curSpeed;
    }




    //void FixedUpdate()
    //{
    //    rb.velocity = new Vector3(playerSpeed * directionInput, rb.velocity.y);
    //}

    public override void MoveUpdate()
    {
        if(directionInputVertical==1)
            tr.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
        if (directionInputVertical == -1)
            tr.Translate(Vector3.back * playerSpeed * Time.deltaTime);
        if (directionInputHorizontal == -1)
            tr.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        if (directionInputHorizontal == 1)
            tr.Translate(Vector3.right * playerSpeed * Time.deltaTime);

        //   rb.velocity = new Vector3(playerSpeed * directionInputHorizontal,0,playerSpeed * directionInputVertical);

        //  tr.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
        //tr.localPosition = new Vector3(tr.position.x + playerSpeed / directionInputHorizontal,0, tr.position.z + playerSpeed / directionInputVertical);
        //   Debug.Log("2LOCAL="+tr.localPosition);
    }

    public override void MoveUp(int InputAxis)
    {
     
        directionInputVertical = InputAxis;
    }
    public override void MoveDown(int InputAxis)
    {
       
        directionInputVertical = InputAxis;
    }
    public override void MoveLeft(int InputAxis)
    {
       
        directionInputHorizontal = InputAxis;
    }
    public override void MoveRight(int InputAxis)
    {
       
        directionInputHorizontal = InputAxis;
    }

    //public override void MoveDiagonal(int InputAxis)
    //{

    //    directionInputHorizontal = InputAxis;

    //}

    //public override void MoveVertical(int InputAxis)
    //{

    //    directionInputVertical = InputAxis;

    //}


    //void Flip()
    //{
    //    facingRight = !facingRight;
    //    Vector3 theScale = transform.localScale;
    //    theScale.x *= -1;
    //    transform.localScale = theScale;
    //}


}

