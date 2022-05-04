using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RingFinal : MonoBehaviour
{
    public Slider slideV;
    public GameObject textMesh;
    private GameObject IMG;
    public GameObject Particles;
    private float Val = 0;

    // Start is called before the first frame update
    void Start()
    {
        IMG = GameObject.Find("BG");
        IMG.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Val = slideV.value;
    }

    public void BlueButton()
    {
        IMG.SetActive(true);
        textMesh.GetComponent<TextMeshProUGUI>().text = "Blue stone x" + slideV.value.ToString();
        Particles.transform.localScale = new Vector3(1, 1, 1);
        Particles.SetActive(true);
    }

    public void PurpleButton()
    {
        IMG.SetActive(true);
        textMesh.GetComponent<TextMeshProUGUI>().text =  "Purple stone x" + slideV.value.ToString();
        Particles.transform.localScale = new Vector3(1, 1, 1);
        Particles.SetActive(true);
    }

    public void CyanButton()
    {
        IMG.SetActive(true);
        textMesh.GetComponent<TextMeshProUGUI>().text = "Cyan stone x" + slideV.value.ToString();
        Particles.transform.localScale = new Vector3(1, 1, 1);
        Particles.SetActive(true);
    }

    public void GreenButton()
    {
        IMG.SetActive(true);
        textMesh.GetComponent<TextMeshProUGUI>().text = "Green stone x" + slideV.value.ToString();
        Particles.transform.localScale = new Vector3(1, 1, 1);
        Particles.SetActive(true);
    }

    public void ThanksButton()
    {
        Particles.SetActive(false);
        IMG.SetActive(false);
    }

}
