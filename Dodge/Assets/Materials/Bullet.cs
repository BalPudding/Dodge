using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody bulletRigidbody; // �̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f; // ź���� �̵��ӵ�

    
    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();

        //������ٵ� �ӵ� = ���ʹ��� * �̵��ӷ�
        bulletRigidbody.velocity = new Vector3(0, 0, 1) * speed;

        //3�ʵڿ� �ڽ��� ���� ������Ʈ�� �ı�
        Destroy(gameObject, 3f);
    }
    private void OnTriggerEnter(Collider other)
    {
     //�浹�� ���� ���� ������Ʈ�� Player �±׸� �����ٸ�,   
     if(other.tag == "Player")
        {
            //���� ���� ������Ʈ���� PlayerController ������Ʈ ��������
            PlayerController playerController = other.GetComponent<PlayerController>();

            //�������κ��� PlayerContorller ������Ʈ�� �������� �� �����ߴٸ�
            if(playerController != null)
            {
                //���� PlayerController ������Ʈ�� Die �޼��� ����
                playerController.Die();
            }
        }
    }
    
}
