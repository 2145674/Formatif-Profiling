using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class SlowCodeToImprove : MonoBehaviour
{
    GameObject cube;

    private float tvRed;
    private float tvGreen;
    private float tvBlue;
    Color nextColor;

    // Start is called before the first frame update
    void Start()
    {
        cube = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor();
        DoSomeLogs();
    }

    private void DoSomeLogs()
    {
        Debug.Log("Blabla");
    }

    private void ChangeColor()
    {
        PrepareColorChange();
        GetComponent<Renderer>().material.color = nextColor;
    }

    private void PrepareColorChange() {
        for(int i = 0; i < 10000; i++) {
            nextColor = ColorForTime();
         }
    
    }

    private Color ColorForTime()
    {
        tvRed += Time.deltaTime;
        if (tvRed > 1f)
        {
            tvRed -= 1f;
        }
        tvGreen += Time.deltaTime*2f;
        if (tvGreen > 1f)
        {
            tvGreen -= 1f;
        }
        tvBlue += Time.deltaTime * 3f;
        if (tvBlue > 1f)
        {
            tvBlue -= 1f;
        }
        return new Color(tvRed, tvGreen, tvBlue);
    }
}
