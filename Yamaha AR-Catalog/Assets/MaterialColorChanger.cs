﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialColorChanger : MonoBehaviour
{
    public Material mat;
    
    // Start is called before the first frame update
   public  void changeColor()
    {
        
        Color c = gameObject.GetComponent<Image>().color;
        mat.color = c;
    }

}