using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("UI&&FirstScreen")]
    [SerializeField]
    private TextMeshProUGUI currentTime;
    [SerializeField] private TMP_InputField playerNameInput;
    [SerializeField]
    private TextMeshProUGUI playerName ;
    [SerializeField]
    private GameObject Join;
    [SerializeField]
    private Button BtnJoin;
    [SerializeField]
    private GameObject FirstScreen;

    [Header("UI&&BottomBar")]
    [SerializeField]
    private Button BtnPlayerInitChange;



    private void Awake()
    {
        playerName.text = playerNameInput.text;
        init();
    }
    void Start()
    {

        BtnJoin.onClick.AddListener(() =>
        {
            Debug.Log("버튼이 클릭되었습니다.");
            FirstScreen.SetActive(false);
        });

        BtnPlayerInitChange.onClick.AddListener(() =>
        {
            FirstScreen.SetActive(true);
        });
    }

    // Update is called once per frame
    void Update()
    {       
        currentTime.text = "현재 시간" + System.DateTime.Now.ToString("HH:mm:ss");

        if (playerNameInput.text.Length > 1 && playerNameInput.text.Length < 11)
        {
            Join.SetActive(true);
            PlayerName();
        }
        else
        {
            Join.SetActive(false);
        }

    }


    public void init()
    {
        Join.SetActive(false);
        FirstScreen.SetActive(true);


    }
    public void PlayerName()
    {
        playerName.text = playerNameInput.text;
    }
}
