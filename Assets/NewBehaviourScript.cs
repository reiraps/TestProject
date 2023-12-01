using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 초기화 - 1
    private void Aweke()
    {
        Debug.Log("초기화1");
    }
    // 초기화 - 2
    private void Start()
    {
        Debug.Log("초기화2");
    }
    //물리연산 끝나고 호출
    private void FixedUpdate()
    {

    }
    // 매 Frame 마다 호출
    private void Update()
    {
        
    }
    // 위에 애들 다 끝나고
    private void LateUpdate()
    {
        
    }
    private void OnEnable()
    {
        Debug.Log("켜졌다");
    }
    private void OnDisable()
    {
        Debug.Log("꺼졌다");
    }

}
