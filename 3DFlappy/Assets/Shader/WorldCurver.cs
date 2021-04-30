using System;
using UnityEngine;

//[ExecuteInEditMode]
public class WorldCurver : MonoBehaviour
{
	[Range(-0.1f, 0.1f)]
	public float curveStrength = 0.01f;
	[Range(-0.1f, 0.1f)]
	public float curveStrengthX = 0.01f;
    int m_CurveStrengthID;
    [SerializeField] private float timeDamper = 0.00001f;
    private bool end = false;
    private float lerpValue;
    private void OnEnable()
    {
        m_CurveStrengthID = Shader.PropertyToID("_CurveStrength");
        m_CurveStrengthID = Shader.PropertyToID("_CurveStrengthX");
    }

	void Update()
	{
		Shader.SetGlobalFloat(m_CurveStrengthID, curveStrength);
		Shader.SetGlobalFloat(m_CurveStrengthID, curveStrengthX);
		
	}

	private void LateUpdate()
	{
		if (end == false)
		{
			lerpValue = Mathf.Lerp(0.1f, 0f, Time.deltaTime * timeDamper);
			if (lerpValue >= 0.0998f)
			{
				end = true;
			}
		}
		if (end == true)
		{
			lerpValue = Mathf.Lerp(-0.1f, 0f, Time.deltaTime * timeDamper);
			if (lerpValue <= -0.0998f)
			{
				end = false;
			}
		}
		print(lerpValue);
		curveStrengthX = lerpValue;
		/*if (curveStrengthX < 0.1f)
		{
			curveStrengthX += Time.deltaTime*timeDamper;
		}
		else if (curveStrengthX >= 0.1f)
		{
		
			curveStrengthX -= Time.deltaTime*timeDamper;
		}
		else if (curveStrengthX > -0.1f)
		{
			curveStrengthX += Time.deltaTime*timeDamper;
		}
		else if (curveStrengthX <= -0.1f)
		{
			curveStrengthX += Time.deltaTime*timeDamper;
		}*/
	}
}
