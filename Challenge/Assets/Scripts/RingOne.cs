using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingOne : MonoBehaviour
{

    private GameObject centralCircle;
    private GameObject IMG;
    private GameObject defRing;
    private GameObject forjarRing;
    private GameObject mezclarRing;
    private GameObject descubrirRing;
    private GameObject fusionarRing;
    private GameObject redRing;
    private GameObject blueRing;
    private GameObject cyanRing;
    private GameObject greenRing;
    private GameObject yellowRing;
    private GameObject purpleRing;
    private int ForjarFlag;
    private int MezclarFlag;
    private int DescubrirFlag;
    private int FusionarFlag;
    // Start is called before the first frame update
    void Start()
    {
        centralCircle = GameObject.Find("centerCircle");
        defRing = GameObject.Find("RingDefault");
        forjarRing = GameObject.Find("RingForjar");
        mezclarRing = GameObject.Find("RingMezclar");
        descubrirRing = GameObject.Find("RingDescubrir");
        fusionarRing = GameObject.Find("RingFusionar");

        redRing = GameObject.Find("RingRed");
        blueRing = GameObject.Find("RingBlue");
        greenRing = GameObject.Find("RingGreen");
        cyanRing = GameObject.Find("RingCyan");
        purpleRing = GameObject.Find("RingPurple");
        yellowRing = GameObject.Find("RingYellow");

        defRing.SetActive(true);
        forjarRing.SetActive(false);
        mezclarRing.SetActive(false);
        descubrirRing.SetActive(false);
        fusionarRing.SetActive(false);

        IMG = centralCircle.transform.GetChild(0).gameObject;
        IMG.SetActive(true);
        ForjarFlag = 0;
        MezclarFlag = 0;
        DescubrirFlag = 0;
        FusionarFlag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ForjarFlag == 1)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime* 100);
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1.5f, 1.5f, 1), Time.deltaTime * 10);
            forjarRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(1, 1, 1), Time.deltaTime * 10);
            blueRing.transform.localScale = Vector3.Lerp(blueRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            cyanRing.transform.localScale = Vector3.Lerp(cyanRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            greenRing.transform.localScale = Vector3.Lerp(greenRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            yellowRing.transform.localScale = Vector3.Lerp(yellowRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            redRing.transform.localScale = Vector3.Lerp(redRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            purpleRing.transform.localScale = Vector3.Lerp(purpleRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            if (transform.rotation.eulerAngles.z > -0.5 && transform.rotation.eulerAngles.z < 0.5 && transform.localScale.x < 1.55 && transform.localScale.y<1.55)
            {
                ForjarFlag = 0;
                forjarRing.transform.localScale = new Vector3(1, 1, 1);
            }
        }

        if (MezclarFlag == 1)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 90), Time.deltaTime * 100);
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1.5f, 1.5f, 1), Time.deltaTime * 10);
            mezclarRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(1, 1, 1), Time.deltaTime * 10);
            blueRing.transform.localScale = Vector3.Lerp(blueRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            cyanRing.transform.localScale = Vector3.Lerp(cyanRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            greenRing.transform.localScale = Vector3.Lerp(greenRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            yellowRing.transform.localScale = Vector3.Lerp(yellowRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            redRing.transform.localScale = Vector3.Lerp(redRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            purpleRing.transform.localScale = Vector3.Lerp(purpleRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            if (transform.rotation.eulerAngles.z > 89.5 && transform.rotation.eulerAngles.z < 90.5 && transform.localScale.x < 1.55 && transform.localScale.y < 1.55)
            {
                MezclarFlag = 0;
                mezclarRing.transform.localScale = new Vector3(1, 1, 1);
            }
        }

        if (DescubrirFlag == 1)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 180), Time.deltaTime * 100);
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1.5f, 1.5f, 1), Time.deltaTime * 10);
            descubrirRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(1, 1, 1), Time.deltaTime * 10);
            blueRing.transform.localScale = Vector3.Lerp(blueRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            cyanRing.transform.localScale = Vector3.Lerp(cyanRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            greenRing.transform.localScale = Vector3.Lerp(greenRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            yellowRing.transform.localScale = Vector3.Lerp(yellowRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            redRing.transform.localScale = Vector3.Lerp(redRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            purpleRing.transform.localScale = Vector3.Lerp(purpleRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            if (transform.rotation.eulerAngles.z > 179.5 && transform.rotation.eulerAngles.z < 180.5 && transform.localScale.x < 1.55 && transform.localScale.y < 1.55)
            {
                DescubrirFlag = 0;
                descubrirRing.transform.localScale = new Vector3(1, 1, 1);
            }
        }

        if (FusionarFlag == 1)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 270), Time.deltaTime * 100);
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1.5f, 1.5f, 1), Time.deltaTime * 10);
            fusionarRing.transform.localScale = Vector3.Lerp(forjarRing.transform.localScale, new Vector3(1, 1, 1), Time.deltaTime * 10);
            blueRing.transform.localScale = Vector3.Lerp(blueRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            cyanRing.transform.localScale = Vector3.Lerp(cyanRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            greenRing.transform.localScale = Vector3.Lerp(greenRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            yellowRing.transform.localScale = Vector3.Lerp(yellowRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            redRing.transform.localScale = Vector3.Lerp(redRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            purpleRing.transform.localScale = Vector3.Lerp(purpleRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            if (transform.rotation.eulerAngles.z > 269.5 && transform.rotation.eulerAngles.z < 270.5 && transform.localScale.x < 1.55 && transform.localScale.y < 1.55)
            {
                FusionarFlag = 0;
                fusionarRing.transform.localScale = new Vector3(1, 1, 1);
            }
        }

    }

    public void ForjarButton()
    {
        DeactivateChildren();
        IMG = centralCircle.transform.GetChild(0).gameObject;
        IMG.SetActive(true);
        ForjarFlag = 1;
        defRing.SetActive(false);
        forjarRing.SetActive(true);
        mezclarRing.SetActive(false);
        descubrirRing.SetActive(false);
        fusionarRing.SetActive(false);
    }

    public void MezclarButton()
    {
        DeactivateChildren();
        IMG = centralCircle.transform.GetChild(1).gameObject;
        IMG.SetActive(true);
        MezclarFlag = 1;
        defRing.SetActive(false);
        forjarRing.SetActive(false);
        mezclarRing.SetActive(true);
        descubrirRing.SetActive(false);
        fusionarRing.SetActive(false);
    }

    public void DescubrirButton()
    {
        DeactivateChildren();
        IMG = centralCircle.transform.GetChild(2).gameObject;
        IMG.SetActive(true);
        DescubrirFlag = 1;
        defRing.SetActive(false);
        forjarRing.SetActive(false);
        mezclarRing.SetActive(false);
        descubrirRing.SetActive(true);
        fusionarRing.SetActive(false);
    }

    public void FusionarButton()
    {
        DeactivateChildren();
        IMG = centralCircle.transform.GetChild(3).gameObject;
        IMG.SetActive(true);
        FusionarFlag = 1;
        defRing.SetActive(false);
        forjarRing.SetActive(false);
        mezclarRing.SetActive(false);
        descubrirRing.SetActive(false);
        fusionarRing.SetActive(true);
    }

    public void DeactivateChildren()
    {
        for (int i = 0; i<centralCircle.transform.childCount; i++)
        {
            centralCircle.transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}

