using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TalkBoxColison : MonoBehaviour
{
    public GameObject TalkStartBox;
    public GameObject TalkBox;
    [SerializeField]
    private TextMeshProUGUI Name;
    [SerializeField]
    private TextMeshProUGUI Talk;
    private string StrTalk = " hi";


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            TalkStartBox.SetActive(true);
            Name.text = gameObject.name;
            if(Name.text == "Pumpkin")
            {
                Talk.text = StrTalk;
            }
            Debug.Log("충돌!");
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TalkStartBox.SetActive(false);
            TalkBox.SetActive(false);
            Debug.Log("충돌빠져나옴");
        }
      
    }
    private void Start()
    {
       
    }

}
