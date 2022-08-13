using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamagePopup : MonoBehaviour
{
    [Header("Curves Properties")]
    [SerializeField] private float height;
    [SerializeField] private AnimationCurve heightCurve;
    [SerializeField] private AnimationCurve opacityCurve;
    [SerializeField] private AnimationCurve scaleCurve;

    private TextMeshProUGUI tmp;
    private Vector3 origin;
    private float time = 0;

    private void Awake()
    {
        tmp = transform.GetChild(0).GetComponent<TextMeshProUGUI>();

        origin = transform.position;
    }

    private void FixedUpdate()
    {
        transform.position = origin + new Vector3(0, 1 + height * heightCurve.Evaluate(time), 0);
        transform.localScale = Vector3.one * scaleCurve.Evaluate(time);
        tmp.color = new Color(1, 1, 1, opacityCurve.Evaluate(time));
	    time += Time.fixedDeltaTime;
       
        if(time > 1)
        {
            Destroy(this.gameObject);
        }
    }
}
