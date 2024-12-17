using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 삼각함수, 백터를 사용해서 만든 공전기능 + 자전기능
public class WheelBallRevolution : MonoBehaviour
{
    public GameObject Planet; 
    public float speed = 6.0f; 
    public float rotationSpeed = 100.0f;
    private float angle = 0f; 
    private float radius; 

    void Start()
    {
        // 현재 위치에서의 반지름을 계산
        radius = Vector3.Distance(transform.position, Planet.transform.position);
        
        // 현재 위치에 맞는 초기 각도 계산
        Vector3 direction = (transform.position - Planet.transform.position).normalized;
        angle = Mathf.Atan2(direction.z, direction.x);
    }

    void Update()
    {
        angle += speed * Time.deltaTime;
        
        // 자전 기능
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
       
        // 공전 기능
        orbitAround(); 
    }
    
    void orbitAround()
    {
        float x = Planet.transform.position.x + radius * Mathf.Cos(angle);
        float z = Planet.transform.position.z + radius * Mathf.Sin(angle);

        
        transform.position = new Vector3(x, transform.position.y, z);
    }
}
