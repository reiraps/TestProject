using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    

    public int x = 5;   //선언하고 할당했다.(초기화)
    private int y = 2;
    protected int z = 3;

    int a = 1;

    int i = 567;
    float f = 2f;
    string s = "안녕";
    char c = 'a';
    bool b = true;

    int I; //선언했다.(초기화)
    int d;


    //I = 5;
    //d = 456;


    private void Start()
    {
        i = 5; // 할당했다.
        d = 456;
    }

    // Test(); 를 작성했을 경우 i값 값은 3 이지만
    // Test를 호출하지 않았기 때문에 i의 현재값은 5 이다.
    void Test()
    {
        i = 3;
    }
}
