using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speedOfMove = 5f;
    public float timeOfTurn = 0.1f;
    float speedOfTurn;

    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
