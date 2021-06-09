﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HourPickerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textPrefab;
    public GameObject content;
    public GameObject pickerFrame;
    private ArrayList choices = new ArrayList();

    void Start()
    {
        for (int i = 11; i <= 26; i++)
        {
            Text text = Text.Instantiate(textPrefab);
            text.text = (i % 12 == 0? 12: i % 12) + "";
            text.transform.parent = content.transform;
            choices.Add(text);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
