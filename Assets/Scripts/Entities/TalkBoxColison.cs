using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkBoxColison : MonoBehaviour
{
    public GameObject TalkStartBox;
    public GameObject TalkBox;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TalkStartBox.SetActive(true);
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

}
