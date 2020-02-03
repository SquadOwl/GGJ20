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

    public Transform objTransform;
    public Sprite iiis;


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


    public void RotateUp()
    {
        objTransform = gameObject.transform.GetChild(6);
        objTransform.transform.localRotation = Quaternion.Euler(90, 180, 0);

        objTransform = gameObject.transform.GetChild(5);
        objTransform.transform.localPosition = new Vector3(0.007f, 0.0530f, 0.506f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 0, 0);

        objTransform = gameObject.transform.GetChild(4);
        objTransform.transform.localPosition = new Vector3(0.008f, 0.053f, -0.534f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 0, 0);

        objTransform = gameObject.transform.GetChild(3);
        objTransform.transform.localPosition = new Vector3(-0.501f, 0.0530f, 0.041f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 90, 0);

        objTransform = gameObject.transform.GetChild(2);
        objTransform.transform.localPosition = new Vector3(0.503f, 0.053f, -0.052f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 270, 0);
    }

    public void RotateDown()
    {
        objTransform = gameObject.transform.GetChild(6);
        //objTransform.transform.localPosition = new Vector3(0, -0.2f, 1);
        objTransform.transform.localRotation = Quaternion.Euler(90, 0, 0);

        objTransform = gameObject.transform.GetChild(5);
        objTransform.transform.localPosition = new Vector3(0.008f, 0.053f, -0.534f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 0, 0);

        objTransform = gameObject.transform.GetChild(4);
        objTransform.transform.localPosition = new Vector3(0.007f, 0.0530f, 0.506f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 0, 0);

        objTransform = gameObject.transform.GetChild(3);
        objTransform.transform.localPosition = new Vector3(0.503f, 0.053f, -0.052f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 270, 0);

        objTransform = gameObject.transform.GetChild(2);
        objTransform.transform.localPosition = new Vector3(-0.501f, 0.0530f, 0.041f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 90, 0);
    }

    public void RotateLeft()
    {
        objTransform = gameObject.transform.GetChild(6);
        objTransform.transform.localRotation = Quaternion.Euler(90, 90, 0);

        objTransform = gameObject.transform.GetChild(5);
        objTransform.transform.localPosition = new Vector3(-0.501f, 0.0530f, 0.041f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 90, 0);

        objTransform = gameObject.transform.GetChild(4);
        objTransform.transform.localPosition = new Vector3(0.503f, 0.053f, -0.052f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 90, 0);

        objTransform = gameObject.transform.GetChild(3);
        objTransform.transform.localPosition = new Vector3(0.008f, 0.053f, -0.534f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 0, 0);

        objTransform = gameObject.transform.GetChild(2);
        objTransform.transform.localPosition = new Vector3(0.007f, 0.0530f, 0.506f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    public void RotateRight()
    {
        objTransform = gameObject.transform.GetChild(6);
        objTransform.transform.localRotation = Quaternion.Euler(90, 270, 0);

        objTransform = gameObject.transform.GetChild(5);
        objTransform.transform.localPosition = new Vector3(0.503f, 0.053f, -0.052f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 90, 0);

        objTransform = gameObject.transform.GetChild(4);
        objTransform.transform.localPosition = new Vector3(-0.501f, 0.0530f, 0.041f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 90, 0);

        objTransform = gameObject.transform.GetChild(3);
        objTransform.transform.localPosition = new Vector3(0.007f, 0.0530f, 0.506f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 180, 0);

        objTransform = gameObject.transform.GetChild(2);
        objTransform.transform.localPosition = new Vector3(0.008f, 0.053f, -0.534f);
        objTransform.transform.localRotation = Quaternion.Euler(0, 0, 0);
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
