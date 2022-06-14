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
            //  ������ ���� �浹�� ������Ʈ�� ������ �޾ƿ� ����.
            RaycastHit hitInfo;
            //  _myTrsf Ʈ�������� ��ġ�� ����, ������ �����Ͽ� ������ ���� ��� 
            //  �浹�� ������Ʈ�� �ִٸ� �ش� ������ hitInfo�� ��ȯ�Ѵ�.
            if (Physics.Raycast(myTrsf.position, myTrsf.forward, out hitInfo, range))
            {
                //  �浹�� ������Ʈ�� �±׸� ���Ѵ�.
                if (hitInfo.collider.gameObject.CompareTag("Check Target"))
                {
                    //  �̸��� ����Ѵ�.
                    Debug.Log(hitInfo.collider.name);
                    //  �浹�� ������ �������� �����Ѵ�.
                    if (isDefaultAddForce)
                        hitInfo.rigidbody.AddForce(myTrsf.forward * power);
                    else
                        hitInfo.rigidbody.AddForceAtPosition(myTrsf.forward * power, hitInfo.point);

                }
            }
        }

    }
}