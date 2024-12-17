using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 3차원에서 자전하는 코드
public class BuckyBallRotation : MonoBehaviour
{
    public float rotationSpeed = 30f; // 회전 속도
    private float angle = 0f;         // 초기값

    void Update()
    {
        // 회전 각도를 시간에 따라 증가
        angle += rotationSpeed * Time.deltaTime;
        
        transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
    }
}
