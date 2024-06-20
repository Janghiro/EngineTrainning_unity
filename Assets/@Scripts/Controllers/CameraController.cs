using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraController : BaseController
{
	

	protected override bool Init()
	{
		if (base.Init() == false)
			return false;

		

		SetCameraSize();

		return true;
	}

	void SetCameraSize()
    {
        float width = Screen.width;
        float height = Screen.height;

        float baseRatio = 1080f / 2280f;
        float currentRatio = width / height;

        if (currentRatio >= baseRatio)
            Camera.main.orthographicSize = 11.4f;
        else
            Camera.main.orthographicSize = 11.4f * baseRatio / currentRatio;
    }

	public void CameraAnimation(string key)
	{
		
	}
}
