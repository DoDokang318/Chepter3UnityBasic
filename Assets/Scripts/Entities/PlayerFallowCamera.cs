using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallowCamera : MonoBehaviour 
{
    public Transform Player; // 카메라가 따라다닐 대상의 Transform을 할당하기 위한 변수
    public float smoothSpeed = 0.004f; // 카메라 이동을 부드럽게 하기 위한 속도 값
    public Vector3 offset; // 카메라와 대상 사이의 거리를 조절하기 위한 변수

    void LateUpdate()
    {
        if (Player != null)
        {
            // 카메라가 따라다닐 위치 계산
            Vector3 desiredPosition = Player.position + offset;

            // 부드러운 이동을 위해 Lerp 함수를 사용하여 현재 위치에서 목표 위치로 이동
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // 카메라의 z 축 값을 항상 원래 값(-10)으로 유지하여 2D 카메라를 유지
            transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        }
    }
}
