using UnityEngine;
using UnityEngine.Events;
public class TriggerEventBehaviour : MonoBehaviour
{
  public UnityEvent triggerEnterEvent;

  private void OnTriggerEvent(Collider other)
  
  {
    triggerEnterEvent.Invoke();
    
  }
}
