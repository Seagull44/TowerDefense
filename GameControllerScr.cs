using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScr : MonoBehaviour
{
    public int cellCount;

    int[] pathID = { 2,22,23,24,25,45,65,85,86,87,88,89,69,49,50,51,52,53,54,55,56,57,58,59,60};

    List<CellScript> AllCells = new List<CellScript> ();

    public GameObject cellPref;
    public Transform cellsGroup;
    void Start()
    {
        CreateCells();
        CreatePath();
    }

    public void CreateCells()
    {
        for (int i = 0; i < cellCount; i++)
        {
            GameObject tmpCell = Instantiate(cellPref);
            tmpCell.transform.SetParent(cellsGroup, false);
            tmpCell.GetComponent<CellScript>().id = i + 1;
            tmpCell.GetComponent<CellScript>().SetState(0);
            AllCells.Add(tmpCell.GetComponent<CellScript>());
        }
    }

    public void CreatePath()
    {
        for(int i=0; i < pathID.Length; i++)
        {
            AllCells[pathID[i]-1].SetState(1);
        }
    }
   
}
