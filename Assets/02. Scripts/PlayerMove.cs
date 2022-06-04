using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float MoveSpeed;
    Vector3 lookDirection;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) ||
            Input.GetKey(KeyCode.RightArrow) ||
            Input.GetKey(KeyCode.UpArrow) ||
            Input.GetKey(KeyCode.DownArrow))
        {
            float forwardKeyValue = Input.GetAxis("Vertical");
            float sideKeyValue = Input.GetAxis("Horizontal");
            lookDirection = forwardKeyValue * Vector3.forward + sideKeyValue * Vector3.right;

            transform.rotation = Quaternion.LookRotation(lookDirection);
            transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        }
    }

}