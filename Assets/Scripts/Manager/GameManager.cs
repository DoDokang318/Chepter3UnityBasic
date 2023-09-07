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
   public TMP_InputField playerNameInput;

   public TextMeshProUGUI playerName ;
    [SerializeField]
    private GameObject Join;
    [SerializeField]
    private Button BtnJoin;
    [SerializeField]
    private GameObject FirstScreen;

    [Header("UI&&BottomBar")]
    [SerializeField]
    private Button BtnPlayerInitChange;

    [Header("UI&&Talk")]
    [SerializeField]
    private Button BtnTalkStart;
    [SerializeField]
    private GameObject TalkBox;

    Character playerCharacter;

    private void Awake()
    {
        playerName.text = playerNameInput.text;
        init();

        playerCharacter = GameObject.Find("Player").GetComponent<Character>(); // Awake���� ȣ��

        playerName.text = playerNameInput.text;
    }
    void Start()
    {

        BtnJoin.onClick.AddListener(() =>
        {
            Debug.Log("��ư�� Ŭ���Ǿ����ϴ�.");
            FirstScreen.SetActive(false);
            PlayerName();
        });

        BtnPlayerInitChange.onClick.AddListener(() =>
        {
            FirstScreen.SetActive(true);
        });
        BtnTalkStart.onClick.AddListener(() =>
        {
            TalkBox.SetActive(true);
        });

    }

    // Update is called once per frame
    void Update()
    {       
        currentTime.text = "���� �ð�" + System.DateTime.Now.ToString("HH:mm:ss");

        if (playerNameInput.text.Length > 1 && playerNameInput.text.Length < 11)
        {
            Join.SetActive(true);
          
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
        playerCharacter.Name = playerNameInput.text;
        playerName.text = playerNameInput.text;
    }
}
