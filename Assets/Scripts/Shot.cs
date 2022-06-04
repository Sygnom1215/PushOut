using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    //  �����Ÿ�
    public float _range = 10f;
    //  �Ŀ�.
    public float _pow = 200f;
    //  Ʈ������ ����.
    Transform _myTrsf;
    //  addforce ��� �񱳸� ���� ���.
    public bool _isDefaultAddForce = true;

    private void Start()
    {
        _myTrsf = transform;
    }

    private void Update()
    {
        Debug.DrawRay(_myTrsf.position, _myTrsf.forward * _range, Color.red);

        //  Space ��ư�� �������� Ȯ��.
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //  ������ ���� �浹�� ������Ʈ�� ������ �޾ƿ� ����.
            RaycastHit hitInfo;
            //  _myTrsf Ʈ�������� ��ġ�� ����, ������ �����Ͽ� ������ ���� ��� 
            //  �浹�� ������Ʈ�� �ִٸ� �ش� ������ hitInfo�� ��ȯ�Ѵ�.
            if (Physics.Raycast(_myTrsf.position, _myTrsf.forward, out hitInfo, _range))
            {
                //  �浹�� ������Ʈ�� �±׸� ���Ѵ�.
                if (hitInfo.collider.gameObject.CompareTag("Check Target"))
                {
                    //  �̸��� ����Ѵ�.
                    Debug.Log(hitInfo.collider.name);
                    //  �浹�� ������ �������� �����Ѵ�.
                    if (_isDefaultAddForce)
                        hitInfo.rigidbody.AddForce(_myTrsf.forward * _pow);
                    else
                        hitInfo.rigidbody.AddForceAtPosition(_myTrsf.forward * _pow, hitInfo.point);

                }
            }
        }

    }
}