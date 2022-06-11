using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    private PlayerMove playerMove;

    private bool IsEffect = false;

    void Start()
    {
        playerMove = player.GetComponent<PlayerMove>();

    }

    //public void DestroyAfterTime()
    //{
    //    Invoke("DestroyObject", 4.0f);
    //}

    public void RunItem()
    {
        Debug.Log("RunItem()");
        //UpSpeed();
        IsEffect = true;
        StartCoroutine(UpSpeed());
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            RunItem();
        }
    }
    //public void UpSpeed()
    //{
    //    playerMove.moveSpeed *= 1.5f;
    //}

    public IEnumerator UpSpeed()
    {
        if(IsEffect == true)
        {
            playerMove.moveSpeed *= 1.5f;
            yield return new WaitForSeconds(3f);
        }
        if (IsEffect == false)
        {
            playerMove.moveSpeed = 10f;
            yield return null;
            // 중단이 안 됨 어케 할 지 공부할 것
        }

    }
}
