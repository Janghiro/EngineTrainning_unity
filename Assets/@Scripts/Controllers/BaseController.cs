using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class BaseController : MonoBehaviour
{
	protected bool _init = false;
	protected Coroutine _coWait;

	void Start()
	{
		Init();
	}

	protected virtual bool Init()
	{
		if (_init)
			return false;

		_init = true;
		return true;
	}

	protected void WaitFor(float seconds)
	{
		if (_coWait != null)
			StopCoroutine(_coWait);

		_coWait = StartCoroutine(CoWait(seconds));
	}

	IEnumerator CoWait(float seconds)
	{
		yield return new WaitForSeconds(seconds);
		_coWait = null;
	}

	
}
