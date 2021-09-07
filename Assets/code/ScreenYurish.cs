using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenYurish: MonoBehaviour
{
    public Camera MainCamera;
    private Vector2 screenBounds;
    private float eni;
    private float balandlik;

    // Use this for initialization
    void Start()
    {
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        eni = transform.GetComponent<SpriteRenderer>().bounds.extents.x;
        balandlik = transform.GetComponent<SpriteRenderer>().bounds.extents.y;
    
    } 

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + eni, screenBounds.x - eni);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + balandlik, screenBounds.y - balandlik);
        transform.position = viewPos;
    }
}
