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
        foreach (Character player in players)  //  플레이어의 이름이 입력되고 실행되어야한다 
        {


            Vector3 spawnPosition = transform.position + new Vector3(488, i + YDistance, 0);
            // 프리팹을 인스턴스화하고 위치를 설정하여 오브젝트를 생성
            GameObject newTextObject = Instantiate(TextPrefab, spawnPosition, Quaternion.identity);
            newTextObject.transform.parent = SpawnLocation.transform.parent;
            // TextMeshProUGUI 컴포넌트를 찾아서 이름 설정
            TextMeshProUGUI textMeshPro = newTextObject.GetComponent<TextMeshProUGUI>();
            if (textMeshPro != null)
            {
                textMeshPro.text = player.Name;
            }
            i += 30;

          
        }
       
    }




}
