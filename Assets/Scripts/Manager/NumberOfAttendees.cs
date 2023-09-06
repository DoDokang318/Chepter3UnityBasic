using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberOfAttendees : MonoBehaviour
{
    private List<string> playerAndNpcNames = new List<string>();
    public GameObject TextPrefab; // 생성할 TextMeshProUGUI 오브젝트 프리팹
    public Transform SpawnLocation; // 오브젝트를 생성할 위치
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
            // 프리팹을 인스턴스화하고 위치를 설정하여 오브젝트를 생성
            GameObject newTextObject = Instantiate(TextPrefab, spawnPosition, Quaternion.identity);
            newTextObject.transform.parent = SpawnLocation.transform.parent;
            // TextMeshProUGUI 컴포넌트를 찾아서 이름 설정
            TextMeshProUGUI textMeshPro = newTextObject.GetComponent<TextMeshProUGUI>();
            if (textMeshPro != null)
            {
                textMeshPro.text = name;
            }
            i += 30;

        }
    }


}
