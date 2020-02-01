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
        control = new ControlTouch(GetComponent<Transform>(), GetComponent<Rigidbody>(), moveSpeed);
    }


    // Update is called once per frame
    //void Update()
    //{
    //    Move();
    //}

    public void MoveUp(int InputAxis)
    {
        control.MoveUp(InputAxis);
    }
    public void MoveDown(int InputAxis)
    {
        control.MoveDown(InputAxis);
    }

    public void MoveLeft(int InputAxis)
    {
        control.MoveLeft(InputAxis);
    }

    public void MoveRight(int InputAxis)
    {
        control.MoveRight(InputAxis);
    }

    void FixedUpdate()
    {
        control.MoveUpdate();
    }

    public void Repair()
    {
        Debug.Log("I use support");
        supportItem.Action();
    }

    public void Attack()
    {
        Debug.Log("I attack");
        attackItem.Attack();
    }

}
