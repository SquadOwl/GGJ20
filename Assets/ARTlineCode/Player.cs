using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float moveSpeed;
    public float baseHealth;

    private Life life;
    private Vector3 moveVector;
    //private CharacterController characterController;
    private AttackItem attackItem = new Gun();
    private SupportItem supportItem = new Repair();
    private Control control;

    // Start is called before the first frame update
    void Start()
    {
        //characterController = GetComponent<CharacterController>();
        life = new Life(baseHealth);
        control = new ControlTouch(GetComponent<Rigidbody>(), moveSpeed);
    }


    // Update is called once per frame
    //void Update()
    //{
    //    Move();
    //}

    public void MoveHorizontal(int InputAxis)
    {
        control.MoveDiagonal(InputAxis);
    }

        public void MoveVertical(int InputAxis)
    {
        control.MoveVertical(InputAxis);
    }

    void FixedUpdate()
    {
        control.MoveUpdate();
    }

    private void Repair ()
    {
        Debug.Log("I use support");
        supportItem.Action();
    }

    private void Attack()
    {

        Debug.Log("I attack");
        attackItem.Attack();
    }

}
