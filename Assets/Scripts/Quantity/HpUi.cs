using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpUi : MonoBehaviour
{
    public GameController player;
    // Start is called before the first frame update
    Vector3 localScale;
    Vector3 localPosition;

    Vector3 StartScale;
    Vector3 StartPosition;

    float newScaleX;
    float newPosX;
    float hpDe;// mau giam

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        StartScale = transform.localScale;
        StartPosition = GameObject.FindWithTag("HpUI").transform.localPosition;
    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        if (player.curEstimate <= 0)
        {
            KillSelf();
        }
        else
        {
            hpDe = (player.maxEstimate - player.curEstimate) / player.maxEstimate;

            newScaleX = (StartScale.x) - (StartScale.x) * hpDe;

            newPosX = StartPosition.x - (StartScale.x - newScaleX) / 2;

            localScale = StartScale;
            localScale.x = newScaleX; /*Scale hien tai*/
            localPosition = StartPosition;
            localPosition.x = newPosX;
            transform.localScale = localScale;
            transform.localPosition = localPosition;

        }


    }
    private void KillSelf()
    {
        Destroy(this.gameObject);
    }
}
