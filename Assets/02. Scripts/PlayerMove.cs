using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    private Animator anim;
    private Vector3 lookDirection;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            float forwardKeyValue = Input.GetAxis("Vertical");
            float sideKeyValue = Input.GetAxis("Horizontal");
            if (anim != null)
                anim.SetBool("IsWalk", true);

            lookDirection = forwardKeyValue * Vector3.forward + sideKeyValue * Vector3.right;

            transform.rotation = Quaternion.LookRotation(lookDirection);
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else
        {
            if(anim != null)
                anim.SetBool("IsWalk", false);
        }
            

    }

}