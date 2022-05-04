using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingColors : MonoBehaviour
{

    private GameObject centralCircle;
    private GameObject IMG;
    private GameObject Ring1;
    private GameObject redRing;
    private GameObject blueRing;
    private GameObject cyanRing;
    private GameObject greenRing;
    private GameObject yellowRing;
    private GameObject purpleRing;
    private GameObject finalRing;
    private int BlueFlag;
    private int CyanFlag;
    private int GreenFlag;
    private int YellowFlag;
    private int RedFlag;
    private int PurpleFlag;
    // Start is called before the first frame update
    void Start()
    {
        centralCircle = GameObject.Find("centerCircle");
        Ring1 = GameObject.Find("Ring1");
        redRing = GameObject.Find("RingRed");
        blueRing = GameObject.Find("RingBlue");
        greenRing = GameObject.Find("RingGreen");
        cyanRing = GameObject.Find("RingCyan");
        purpleRing = GameObject.Find("RingPurple");
        yellowRing = GameObject.Find("RingYellow");
        finalRing = GameObject.Find("RingFinal");

        IMG = centralCircle.transform.GetChild(0).gameObject;
        BlueFlag = 0;
        CyanFlag = 0;
        GreenFlag = 0;
        YellowFlag = 0;
        RedFlag = 0;
        PurpleFlag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (BlueFlag == 1)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime* 100);
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(2, 2, 1), Time.deltaTime * 10);
            Ring1.transform.localScale = Vector3.Lerp(Ring1.transform.localScale, new Vector3(3, 3, 1), Time.deltaTime * 10);
            blueRing.transform.localScale = Vector3.Lerp(blueRing.transform.localScale, new Vector3(1, 1, 1), Time.deltaTime * 10);
            cyanRing.transform.localScale = Vector3.Lerp(cyanRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            greenRing.transform.localScale = Vector3.Lerp(greenRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            yellowRing.transform.localScale = Vector3.Lerp(yellowRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            redRing.transform.localScale = Vector3.Lerp(redRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            purpleRing.transform.localScale = Vector3.Lerp(purpleRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            finalRing.transform.localScale = Vector3.Lerp(finalRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            if (transform.rotation.eulerAngles.z > -0.5 && transform.rotation.eulerAngles.z < 0.5 && transform.localScale.x > 1.95 && transform.localScale.x < 2.05)
            {
                BlueFlag = 0;
            }
        }

        if (CyanFlag == 1)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 300), Time.deltaTime * 100);
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(2, 2, 1), Time.deltaTime * 10);
            Ring1.transform.localScale = Vector3.Lerp(Ring1.transform.localScale, new Vector3(3, 3, 1), Time.deltaTime * 10);
            blueRing.transform.localScale = Vector3.Lerp(blueRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            cyanRing.transform.localScale = Vector3.Lerp(cyanRing.transform.localScale, new Vector3(1, 1, 1), Time.deltaTime * 10);
            greenRing.transform.localScale = Vector3.Lerp(greenRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            yellowRing.transform.localScale = Vector3.Lerp(yellowRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            redRing.transform.localScale = Vector3.Lerp(redRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            purpleRing.transform.localScale = Vector3.Lerp(purpleRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            finalRing.transform.localScale = Vector3.Lerp(finalRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            if (transform.rotation.eulerAngles.z >299.5 && transform.rotation.eulerAngles.z < 300.5 && transform.localScale.x > 1.95 && transform.localScale.x < 2.05)
            {
                CyanFlag = 0;
            }
        }

        if (GreenFlag == 1)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 240), Time.deltaTime * 100);
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(2, 2, 1), Time.deltaTime * 10);
            Ring1.transform.localScale = Vector3.Lerp(Ring1.transform.localScale, new Vector3(3, 3, 1), Time.deltaTime * 10);
            blueRing.transform.localScale = Vector3.Lerp(blueRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            cyanRing.transform.localScale = Vector3.Lerp(cyanRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            greenRing.transform.localScale = Vector3.Lerp(greenRing.transform.localScale, new Vector3(1, 1, 1), Time.deltaTime * 10);
            yellowRing.transform.localScale = Vector3.Lerp(yellowRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            redRing.transform.localScale = Vector3.Lerp(redRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            purpleRing.transform.localScale = Vector3.Lerp(purpleRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            finalRing.transform.localScale = Vector3.Lerp(finalRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            if (transform.rotation.eulerAngles.z > 239.5 && transform.rotation.eulerAngles.z < 240.5 && transform.localScale.x > 1.95 && transform.localScale.x < 2.05)
            {
                GreenFlag = 0;
            }
        }

        if (YellowFlag == 1)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 180), Time.deltaTime * 100);
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(2, 2, 1), Time.deltaTime * 10);
            Ring1.transform.localScale = Vector3.Lerp(Ring1.transform.localScale, new Vector3(3, 3, 1), Time.deltaTime * 10);
            blueRing.transform.localScale = Vector3.Lerp(blueRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            cyanRing.transform.localScale = Vector3.Lerp(cyanRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            greenRing.transform.localScale = Vector3.Lerp(greenRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            yellowRing.transform.localScale = Vector3.Lerp(yellowRing.transform.localScale, new Vector3(1, 1, 1), Time.deltaTime * 10);
            redRing.transform.localScale = Vector3.Lerp(redRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            purpleRing.transform.localScale = Vector3.Lerp(purpleRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            finalRing.transform.localScale = Vector3.Lerp(finalRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            if (transform.rotation.eulerAngles.z > 179.5 && transform.rotation.eulerAngles.z < 180.5 && transform.localScale.x > 1.95 && transform.localScale.x < 2.05)
            {
               YellowFlag = 0;
            }
        }

        if (RedFlag == 1)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 120), Time.deltaTime * 100);
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(2, 2, 1), Time.deltaTime * 10);
            Ring1.transform.localScale = Vector3.Lerp(Ring1.transform.localScale, new Vector3(3, 3, 1), Time.deltaTime * 10);
            blueRing.transform.localScale = Vector3.Lerp(blueRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            cyanRing.transform.localScale = Vector3.Lerp(cyanRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            greenRing.transform.localScale = Vector3.Lerp(greenRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            yellowRing.transform.localScale = Vector3.Lerp(yellowRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            redRing.transform.localScale = Vector3.Lerp(redRing.transform.localScale, new Vector3(1, 1, 1), Time.deltaTime * 10);
            purpleRing.transform.localScale = Vector3.Lerp(purpleRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            finalRing.transform.localScale = Vector3.Lerp(finalRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            if (transform.rotation.eulerAngles.z > 119.5 && transform.rotation.eulerAngles.z < 120.5 && transform.localScale.x > 1.95 && transform.localScale.x < 2.05)
            {
                RedFlag = 0;
            }
        }

        if (PurpleFlag == 1)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 60), Time.deltaTime * 100);
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(2, 2, 1), Time.deltaTime * 10);
            Ring1.transform.localScale = Vector3.Lerp(Ring1.transform.localScale, new Vector3(3, 3, 1), Time.deltaTime * 10);
            blueRing.transform.localScale = Vector3.Lerp(blueRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            cyanRing.transform.localScale = Vector3.Lerp(cyanRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            greenRing.transform.localScale = Vector3.Lerp(greenRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            yellowRing.transform.localScale = Vector3.Lerp(yellowRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            redRing.transform.localScale = Vector3.Lerp(redRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            purpleRing.transform.localScale = Vector3.Lerp(purpleRing.transform.localScale, new Vector3(1, 1, 1), Time.deltaTime * 10);
            finalRing.transform.localScale = Vector3.Lerp(finalRing.transform.localScale, new Vector3(0, 0, 0), Time.deltaTime * 10);
            if (transform.rotation.eulerAngles.z > 59.5 && transform.rotation.eulerAngles.z < 60.5 && transform.localScale.x > 1.95 && transform.localScale.x < 2.05)
            {
                PurpleFlag = 0;
            }
        }
    }

    public void BlueButton()
    {
        DeactivateChildren();
        IMG = centralCircle.transform.GetChild(4).gameObject;
        IMG.SetActive(true);
        BlueFlag = 1;
    }

    public void CyanButton()
    {
        DeactivateChildren();
        IMG = centralCircle.transform.GetChild(5).gameObject;
        IMG.SetActive(true);
        CyanFlag = 1;
    }

    public void GreenButton()
    {
        DeactivateChildren();
        IMG = centralCircle.transform.GetChild(6).gameObject;
        IMG.SetActive(true);
        GreenFlag = 1;
    }

    public void YellowButton()
    {
        DeactivateChildren();
        IMG = centralCircle.transform.GetChild(7).gameObject;
        IMG.SetActive(true);
        YellowFlag = 1;
    }

    public void RedButton()
    {
        DeactivateChildren();
        IMG = centralCircle.transform.GetChild(8).gameObject;
        IMG.SetActive(true);
        RedFlag = 1;
    }

    public void PurpleButton()
    {
        DeactivateChildren();
        IMG = centralCircle.transform.GetChild(9).gameObject;
        IMG.SetActive(true);
        PurpleFlag = 1;
    }

    public void DeactivateChildren()
    {
        for (int i = 0; i < centralCircle.transform.childCount; i++)
        {
            centralCircle.transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}

