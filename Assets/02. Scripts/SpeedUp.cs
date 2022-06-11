using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    private PlayerMove playerMove;
    void Start()
    {
        playerMove = GetComponent<PlayerMove>();
    }

    //public void DestroyAfterTime()
    //{
    //    Invoke("DestroyObject", 4.0f);
    //}

    public void RunItem()
    {
        Debug.Log("RunItem()");
        UpSpeed();
        //playerMove.moveSpeed *= 1.5f;
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            RunItem();
        }
    }
    public void UpSpeed()
    {
        playerMove.moveSpeed = 10f;
    }
}
