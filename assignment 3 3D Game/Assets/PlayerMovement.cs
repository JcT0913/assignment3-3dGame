using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speedOfMove = 5f;
    public float timeOfTurn = 0.1f;
    float speedOfTurn;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = transform.GetChild(0).GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(x, 0f, y).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float angleToRotate = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, angleToRotate, ref speedOfTurn, timeOfTurn);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            controller.Move(direction * speedOfMove * Time.deltaTime);
        }

        // triggers for animations
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("runTrigger");
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetTrigger("idleTrigger");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("runTrigger");
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetTrigger("idleTrigger");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("runTrigger");
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetTrigger("idleTrigger");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("runTrigger");
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetTrigger("idleTrigger");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetTrigger("runTrigger");
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.SetTrigger("idleTrigger");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetTrigger("runTrigger");
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetTrigger("idleTrigger");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetTrigger("runTrigger");
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.SetTrigger("idleTrigger");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetTrigger("runTrigger");
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetTrigger("idleTrigger");
        }
    }
}
