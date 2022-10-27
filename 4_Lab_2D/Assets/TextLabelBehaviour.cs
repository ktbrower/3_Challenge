using System;
using System.Globalization;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class TextLabelBehaviour : MonoBehaviour
{
 public Text label;
 public FloatData dataobj;
 private void Start()
 {
  label = GetComponent<Text>();
  UpdateLabel();
 }

 public void UpdateLabel()
 {
  label.text = dataobj.value.ToString(CultureInfo.InvariantCulture);
 }
}
