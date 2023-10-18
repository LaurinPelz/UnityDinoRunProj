using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    private TMPro.TextMeshPro m_TextMeshPro;
    private float points = 0;
    
    // Start is called before the first frame update
    void Start()
    {
       m_TextMeshPro = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        m_TextMeshPro.text = ((int)points).ToString();
    }
}
