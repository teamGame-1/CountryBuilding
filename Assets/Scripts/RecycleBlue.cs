using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleBlue : MonoBehaviour
{
    public AudioClip trash;
    public AudioSource ad;
    GameController gameController;
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        trash = Resources.Load<AudioClip>("trash");
        ad = this.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("taisudung"))
        {
            Destroy(collision.gameObject);
            gameController.punishmentMoneyText.color = Color.yellow;
            gameController.punishmentMoneyText.text = "+10$";
            gameController.money += 10;
            
            Invoke("PrintVoidText", 1f);
            ad.PlayOneShot(trash);
        }
        if (collision.CompareTag("huuco") || collision.CompareTag("voco"))
        {
            Destroy(collision.gameObject);
            gameController.punishmentMoneyText.color = Color.red;
            gameController.punishmentMoneyText.text = "-15$";
            gameController.money -= 15;
            
            Invoke("PrintVoidText", 1f);
            ad.PlayOneShot(trash);
        }
    }
    void PrintVoidText()
    {
        gameController.punishmentMoneyText.text = "";
    }
}
