using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // �ʱ�ȭ - 1
    private void Aweke()
    {
        Debug.Log("�ʱ�ȭ1");
    }
    // �ʱ�ȭ - 2
    private void Start()
    {
        Debug.Log("�ʱ�ȭ2");
    }
    //�������� ������ ȣ��
    private void FixedUpdate()
    {

    }
    // �� Frame ���� ȣ��
    private void Update()
    {
        
    }
    // ���� �ֵ� �� ������
    private void LateUpdate()
    {
        
    }
    private void OnEnable()
    {
        Debug.Log("������");
    }
    private void OnDisable()
    {
        Debug.Log("������");
    }

}
