using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    

    public int x = 5;   //�����ϰ� �Ҵ��ߴ�.(�ʱ�ȭ)
    private int y = 2;
    protected int z = 3;

    int a = 1;

    int i = 567;
    float f = 2f;
    string s = "�ȳ�";
    char c = 'a';
    bool b = true;

    int I; //�����ߴ�.(�ʱ�ȭ)
    int d;


    //I = 5;
    //d = 456;


    private void Start()
    {
        i = 5; // �Ҵ��ߴ�.
        d = 456;
    }

    // Test(); �� �ۼ����� ��� i�� ���� 3 ������
    // Test�� ȣ������ �ʾұ� ������ i�� ���簪�� 5 �̴�.
    void Test()
    {
        i = 3;
    }
}
