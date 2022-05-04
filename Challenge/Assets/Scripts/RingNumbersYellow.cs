using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingNumbersYellow : MonoBehaviour
{
    private GameObject centralCircle;
    private GameObject IMG;
    private GameObject Ring1;
    private GameObject redRing;
    private GameObject finalRing;
    private GameObject forjarRing;
    private GameObject mezclarRing;
    private GameObject descubrirRing;
    private GameObject fusionarRing;
    private int flag1 = 0;
    private int flag2 = 0;
    private int flag3 = 0;

    // Start is called before the first frame update
    void Start()
    {
        centralCircle = GameObject.Find("centerCircle");
        Ring1 = GameObject.Find("Ring1");
        redRing = GameObject.Find("RingRed");
        finalRing = GameObject.Find("RingFinal");
        forjarRing = GameObject.Find("RingForjar");
        mezclarRing = GameObject.Find("RingMezclar");
        descubrirRing = GameObject.Find("RingDescubrir");
        fusionarRing = GameObject.Find("RingFusionar");
        IMG = centralCircle.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag1 == 1)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 120), Time.deltaTime * 100);
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(2, 2, 1), Time.deltaTime * 10);
            Ring1.transform.localScale = Vector3.Lerp(Ring1.transform.localScale, new Vector3(5, 5, 1), Time.deltaTime * 10);
            finalRing.transform.localScale = Vector3.Lerp(finalRing.transform.localScale, new Vector3(1, 1, 1), Time.deltaTime * 10);
            forjarRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(4, 4, 1), Time.deltaTime * 10);
            mezclarRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(4, 4, 1), Time.deltaTime * 10);
            descubrirRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(4, 4, 1), Time.deltaTime * 10);
            fusionarRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(4, 4, 1), Time.deltaTime * 10);
            if (transform.rotation.eulerAngles.z > 119.5 && transform.rotation.eulerAngles.z < 120.5 && transform.localScale.x > 1.95 && transform.localScale.y > 1.95)
            {
                flag1 = 0;
            }
        }

        if (flag2 == 1)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * 100);
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(2, 2, 1), Time.deltaTime * 10);
            Ring1.transform.localScale = Vector3.Lerp(Ring1.transform.localScale, new Vector3(5, 5, 1), Time.deltaTime * 10);
            finalRing.transform.localScale = Vector3.Lerp(finalRing.transform.localScale, new Vector3(1, 1, 1), Time.deltaTime * 10);
            forjarRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(4, 4, 1), Time.deltaTime * 10);
            mezclarRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(4, 4, 1), Time.deltaTime * 10);
            descubrirRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(4, 4, 1), Time.deltaTime * 10);
            fusionarRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(4, 4, 1), Time.deltaTime * 10);
            if (transform.rotation.eulerAngles.z > -0.5 && transform.rotation.eulerAngles.z < 0.5 && transform.localScale.x > 1.95 && transform.localScale.y > 1.95)
            {
                flag2 = 0;
            }
        }

        if (flag3 == 1)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 240), Time.deltaTime * 100);
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(2, 2, 1), Time.deltaTime * 10);
            Ring1.transform.localScale = Vector3.Lerp(Ring1.transform.localScale, new Vector3(5, 5, 1), Time.deltaTime * 10);
            finalRing.transform.localScale = Vector3.Lerp(finalRing.transform.localScale, new Vector3(1, 1, 1), Time.deltaTime * 10);
            forjarRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(4, 4, 1), Time.deltaTime * 10);
            mezclarRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(4, 4, 1), Time.deltaTime * 10);
            descubrirRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(4, 4, 1), Time.deltaTime * 10);
            fusionarRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(4, 4, 1), Time.deltaTime * 10);
            if (transform.rotation.eulerAngles.z > 239.5 && transform.rotation.eulerAngles.z < 240.5 && transform.localScale.x > 1.95 && transform.localScale.y > 1.95)
            {
                flag3 = 0;
            }
        }
    }

    public void button1()
    {
        DeactivateChildren();
        IMG = centralCircle.transform.GetChild(25).gameObject;
        IMG.SetActive(true);
        flag1 = 1;
    }

    public void button2()
    {
        DeactivateChildren();
        IMG = centralCircle.transform.GetChild(26).gameObject;
        IMG.SetActive(true);
        flag2 = 1;
    }

    public void button3()
    {
        DeactivateChildren();
        IMG = centralCircle.transform.GetChild(27).gameObject;
        IMG.SetActive(true);
        flag3 = 1;
    }

    public void DeactivateChildren()
    {
        for (int i = 0; i < centralCircle.transform.childCount; i++)
        {
            centralCircle.transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}