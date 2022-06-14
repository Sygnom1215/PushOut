using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField]
    private float range = 10f;
    [SerializeField]
    private float power = 200f;
    Transform myTrsf;
    public bool isDefaultAddForce = true;

    private void Start()
    {
        myTrsf = transform;
    }

    private void Update()
    {
        Debug.DrawRay(myTrsf.position, myTrsf.forward * range, Color.red);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            //  가상의 선에 충돌한 오브젝트의 정보를 받아올 변수.
            RaycastHit hitInfo;
            //  _myTrsf 트랜스폼의 위치와 방향, 범위를 참고하여 가상의 선을 쏜뒤 
            //  충돌한 오브젝트가 있다면 해당 정보를 hitInfo에 반환한다.
            if (Physics.Raycast(myTrsf.position, myTrsf.forward, out hitInfo, range))
            {
                //  충돌한 오브젝트의 태그를 비교한다.
                if (hitInfo.collider.gameObject.CompareTag("Check Target"))
                {
                    //  이름을 출력한다.
                    Debug.Log(hitInfo.collider.name);
                    //  충돌한 지점에 물리력을 적용한다.
                    if (isDefaultAddForce)
                        hitInfo.rigidbody.AddForce(myTrsf.forward * power);
                    else
                        hitInfo.rigidbody.AddForceAtPosition(myTrsf.forward * power, hitInfo.point);

                }
            }
        }

    }
}