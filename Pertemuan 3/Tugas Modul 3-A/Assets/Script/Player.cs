using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
 public Text bumiText;
 private int totalBumi = 0;
 void Start()
 {
 UpdateBumiText();
 }
 void OnTriggerEnter2D(Collider2D hit)
 {
 if (hit.CompareTag("Bumi"))
 {
 totalBumi++;
 UpdateBumiText();
 Destroy(hit.gameObject);
 }
 }
 private void UpdateBumiText()
 {
 string bumiMessage = "Planet = " + totalBumi;
 bumiText.text = bumiMessage;
 }
}