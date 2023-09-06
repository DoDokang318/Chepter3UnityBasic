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

    void Start()
    {   
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] npcs = GameObject.FindGameObjectsWithTag("Npc");
      



        foreach (GameObject player in players)
        {
            playerAndNpcNames.Add(player.name);
        }

        foreach (GameObject npc in npcs)
        {
            playerAndNpcNames.Add(npc.name);
        }

        foreach (string name in playerAndNpcNames)
        {

            Vector3 spawnPosition = transform.position + new Vector3(190, i + YDistance, 0);
            // �������� �ν��Ͻ�ȭ�ϰ� ��ġ�� �����Ͽ� ������Ʈ�� ����
            GameObject newTextObject = Instantiate(TextPrefab, spawnPosition, Quaternion.identity);
            newTextObject.transform.parent = SpawnLocation.transform.parent;
            // TextMeshProUGUI ������Ʈ�� ã�Ƽ� �̸� ����
            TextMeshProUGUI textMeshPro = newTextObject.GetComponent<TextMeshProUGUI>();
            if (textMeshPro != null)
            {
                textMeshPro.text = name;
            }
            i += 30;

        }
    }


}
