using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ValueSlider : MonoBehaviour
{
    public GameObject textMesh;
    public Slider sliderUI;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.GetComponent<TextMeshProUGUI>().text = sliderUI.value.ToString();
    }
}
