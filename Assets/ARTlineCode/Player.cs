using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float moveSpeed;
    public float baseHealth;
    public float damage;

    private Life life;
    private Vector3 moveVector;
    private CharacterController characterController;
    private AttackItem attackItem = new Gun();
    private SupportItem supportItem = new Repair();

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        life = new Life(baseHealth);
    }

    private void FixedUpdate()
    {
        //Move();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxis("Horizontal") * moveSpeed;
        moveVector.z = Input.GetAxis("Vertical") * moveSpeed;

        characterController.Move(moveVector * Time.deltaTime);
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
