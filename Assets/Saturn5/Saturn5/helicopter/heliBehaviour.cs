using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heliBehaviour : MonoBehaviour {
    public Transform hp1;
    public Transform hp2;
    public Transform hp3;
    public Transform hp4;
    public Transform hp5;

    public static bool moveTo1 = true;
    public static bool moveTo2;
    public static bool moveTo3;
    public static bool moveTo4;
    public static bool flyAway;

    float heliMoveSpeed = .5f;
    
    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        if (flyAway){
            moveTo1 = false;
            moveTo2 = false;
            moveTo3 = false;
            moveTo4 = false;
        }

        if (moveTo1)
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, hp1.position, heliMoveSpeed);
            Quaternion targetRotation = Quaternion.LookRotation(hp1.transform.position - transform.position);
            // Smoothly rotate towards the target point.
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 2f * Time.deltaTime);

            //transform.LookAt(hp1.position);
        }
        if (moveTo2)
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, hp2.position, heliMoveSpeed);
            Quaternion targetRotation = Quaternion.LookRotation(hp2.transform.position - transform.position);
            // Smoothly rotate towards the target point.
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 2f * Time.deltaTime);

            //transform.LookAt(hp2.position);
        }
        if (moveTo3)
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, hp3.position, heliMoveSpeed);
            Quaternion targetRotation = Quaternion.LookRotation(hp3.transform.position - transform.position);
            // Smoothly rotate towards the target point.
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 2f * Time.deltaTime);

            //transform.LookAt(hp3.position);
        }
        if (moveTo4){
            transform.position = Vector3.MoveTowards(gameObject.transform.position, hp4.position, heliMoveSpeed);
            Quaternion targetRotation = Quaternion.LookRotation(hp4.transform.position - transform.position);
            // Smoothly rotate towards the target point.
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 2f * Time.deltaTime);

            //transform.LookAt(hp4.position);
        }
        if (flyAway)
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, hp5.position, heliMoveSpeed);
            Quaternion targetRotation = Quaternion.LookRotation(hp5.transform.position - transform.position);
            // Smoothly rotate towards the target point.
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 2f * Time.deltaTime);

            //transform.LookAt(hp5.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "hp1")
        {
            moveTo1 = false;
            moveTo2 = true;
            heliMoveSpeed = .3f;
        }
        else if (other.tag == "hp2")
        {
            moveTo2 = false;
            moveTo3 = true;
            heliMoveSpeed = .2f;
        }
        else if (other.tag == "hp3")
        {
            moveTo2 = false;
            moveTo3 = false;
            moveTo4 = true;
            heliMoveSpeed = .2f;
        }
        else if (other.tag == "hp4")
        {
            moveTo1 = true;
            moveTo2 = false;
            moveTo3 = false;
            moveTo4 = false;
            heliMoveSpeed = .2f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "hp1")
        {
            heliMoveSpeed = .5f;
        }
        else if (other.tag == "hp2")
        {
            heliMoveSpeed = .5f;
        }
        else if (other.tag == "hp3")
        {
            heliMoveSpeed = .5f;
        }
        else if (other.tag == "hp4")
        {
            heliMoveSpeed = .5f;
        }
    }
}
