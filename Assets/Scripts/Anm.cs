using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var worldHeight = Camera.main.orthographicSize * 2f;
        var worldWight = worldHeight * Screen.width / Screen.height;
        transform.localScale = new Vector3(worldWight, worldHeight, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
