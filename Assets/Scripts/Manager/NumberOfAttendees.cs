using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberOfAttendees : MonoBehaviour
{

   
    

    private List<string> playerAndNpcNames = new List<string>();
    public GameObject TextPrefab; // ������ TextMeshProUGUI ������Ʈ ������
    public Transform SpawnLocation; // ������Ʈ�� ������ ��ġ
    public float YDistance = 10.0f;
    int i = 1;
    Character[] players;

    private void Awake()
    {
       players = GameObject.FindObjectsOfType<Character>();
    }
    void Start()
    {
      
    }


    public  void NameList()
    {
        foreach (Character player in players)  //  �÷��̾��� �̸��� �Էµǰ� ����Ǿ���Ѵ� 
        {


            Vector3 spawnPosition = transform.position + new Vector3(488, i + YDistance, 0);
            // �������� �ν��Ͻ�ȭ�ϰ� ��ġ�� �����Ͽ� ������Ʈ�� ����
            GameObject newTextObject = Instantiate(TextPrefab, spawnPosition, Quaternion.identity);
            newTextObject.transform.parent = SpawnLocation.transform.parent;
            // TextMeshProUGUI ������Ʈ�� ã�Ƽ� �̸� ����
            TextMeshProUGUI textMeshPro = newTextObject.GetComponent<TextMeshProUGUI>();
            if (textMeshPro != null)
            {
                textMeshPro.text = player.Name;
            }
            i += 30;

          
        }
       
    }




}
