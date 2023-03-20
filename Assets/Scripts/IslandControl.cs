using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IslandControl : MonoBehaviour
{
    public int weetInv;
    public int weetCol = 0;
    public Text weetInInv;

    private void Update()
    {
        
    }
    public void GetWeet()
    {
        weetInv += weetCol;
    }
}
