using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{
    public int point;
    public bool addpoint;
    public TextMeshProUGUI score_text;
    void Start()
    {
        addpoint = false;
        point = 0;
    }


    void Update()
    {
        if(addpoint == true)
        {
            point += 1;
            addpoint = false;
            Debug.Log(point);
        }
        score_text.SetText(point.ToString());
    }
}
