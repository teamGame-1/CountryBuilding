using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anm : MonoBehaviour
{
    public Image image;
    public Sprite[] sprites;
    public float animationSpeed;

    public IEnumerator nukeMethod()
    {
        //destroy all game objects
        for (int i = 0; i < sprites.Length; i++)
        {
            image.sprite = sprites[i];
            yield return new WaitForSeconds(animationSpeed);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
