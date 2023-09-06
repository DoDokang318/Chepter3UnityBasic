using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallowCamera : MonoBehaviour 
{
    public Transform Player; // ī�޶� ����ٴ� ����� Transform�� �Ҵ��ϱ� ���� ����
    public float smoothSpeed = 0.004f; // ī�޶� �̵��� �ε巴�� �ϱ� ���� �ӵ� ��
    public Vector3 offset; // ī�޶�� ��� ������ �Ÿ��� �����ϱ� ���� ����

    void LateUpdate()
    {
        if (Player != null)
        {
            // ī�޶� ����ٴ� ��ġ ���
            Vector3 desiredPosition = Player.position + offset;

            // �ε巯�� �̵��� ���� Lerp �Լ��� ����Ͽ� ���� ��ġ���� ��ǥ ��ġ�� �̵�
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // ī�޶��� z �� ���� �׻� ���� ��(-10)���� �����Ͽ� 2D ī�޶� ����
            transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        }
    }
}
