using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerInventoryDisplay : MonoBehaviour
{
 public Image[] medaliPlaceholders;
 public Sprite iconMedaliYellow;
 public Sprite iconMedaliGrey;
 public void OnChangeMedaliTotal(int medaliTotal)
 {
 for (int i = 0; i < medaliPlaceholders.Length; ++i)
 {
 if (i < medaliTotal)
 medaliPlaceholders[i].sprite = iconMedaliYellow;
 else
 medaliPlaceholders[i].sprite = iconMedaliGrey;
 }
 }
}

