using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRubbish : MonoBehaviour
{
    public float moveSpeed = 5f;
    Vector3 mousePos;
    bool choose = false;
    // Start is called before the first frame update
    void Start()
    {
        mousePos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && choose)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            transform.position = Vector3.Lerp(transform.position, mousePos, moveSpeed);
        }
        
    }
    private void OnMouseDown()
    {
        choose = !choose;
    }
}
