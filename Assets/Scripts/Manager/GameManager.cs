using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI currentTime;
    public InputField playerNameInput;
    [SerializeField]
    private string playerName = null;
    [SerializeField]
    private GameObject Join;
    [SerializeField]
    private Button BtnJoin;



    private void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
    }
    void Start()
    {
        if(playerName.Length>0&& playerName.Length <11)
        {
            Join.SetActive(true);
            PlayerName();
        }
        BtnJoin.onClick.AddListener(() =>
        {
            Debug.Log("버튼이 클릭되었습니다.");
          
        });
    }

    // Update is called once per frame
    void Update()
    {
        currentTime.text = "현재 시간" + System.DateTime.Now.ToString("HH:mm:ss");

    }


    public void init()
    {
        Join.SetActive(false);

    }
    public void PlayerName()
    {
        playerName = playerNameInput.text;
    }
}
