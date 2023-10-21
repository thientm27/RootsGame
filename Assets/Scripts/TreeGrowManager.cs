
using System;
using UnityEngine;

public class TreeGrowManager : MonoBehaviour
{
    public GameObject[] trees;

    
    void Start()
    {

        CheckVar();
    }

    public void CheckVar()
    {
        var cap1 =  PlayerPrefs.GetInt("Cap"+0, 0);
        var cap2 =  PlayerPrefs.GetInt("Cap"+1, 0);
        var cap3 =  PlayerPrefs.GetInt("Cap"+2, 0);
        var cap4 =  PlayerPrefs.GetInt("Cap"+3, 0);
        var cap5 =  PlayerPrefs.GetInt("Cap"+4, 0);
        var sum = cap1 + cap2 + cap3 + cap4 + cap5;
        ProcessStartTree(sum);
    }
    public void ChangeTree(int index)
    {
        foreach (var tr in trees)
        {
            tr.SetActive(false);
        } 
        trees[index].SetActive(true);
    }

    public void ProcessStartTree(int sum)
    {
        if (sum >= 10 && sum < 20)
        {
            ChangeTree(1);
        }else if (sum >= 20 && sum < 30)
        {
            ChangeTree(2);
        }else if (sum >= 30 && sum <= 40)
        {
            ChangeTree(3);
        }
        else
        {
            ChangeTree(0);
        }
    }

    
}
