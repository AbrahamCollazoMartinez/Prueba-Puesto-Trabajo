using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    public int Points_N = 0;
    public TMP_Text PointsT;

    int PointsEarning;

    private void Start()
    {
        PointsT.text = "Score: " + Points_N;
    }

    public void EarnPoints(int P)
    {
        PointsEarning = Points_N + P;
        PointsT.text = "Score: " + PointsEarning;

    }

}
