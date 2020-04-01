using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    [SerializeField] private Image MyLabel;
    [SerializeField] private Text MyName;
    [SerializeField] private Transform position;
   // Start is called before the first frame update


   // Update is called once per frame
   void Update()
    {
        MyLabel.transform.position = position.position;
    }
}
