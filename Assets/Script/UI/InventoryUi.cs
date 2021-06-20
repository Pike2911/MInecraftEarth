using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PGME.Core;
public class InventoryUi : MonoBehaviour
{
    [SerializeField] Text DirtText;
    [SerializeField] Text WoodText;
    [SerializeField] Text GrassText;

    private void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        DirtText.text = player.GetComponent<Player>().dirt.ToString();
        WoodText.text = player.GetComponent<Player>().wood.ToString(); ;
        GrassText.text = player.GetComponent<Player>().grass.ToString(); ;
    }
}