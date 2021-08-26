using UnityEngine;
using DG.Tweening;

public class DOTweenTest : MonoBehaviour
{
    private void Start()
    {
        transform.DORotate(new Vector3(0, 90, 0), 10);
    }
}
