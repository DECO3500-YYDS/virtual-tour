using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class zuos : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("/Main Camera");
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        cam.GetComponent<roomab>().iscanzuos();
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        cam.GetComponent<roomab>().isnotcanzuos();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
