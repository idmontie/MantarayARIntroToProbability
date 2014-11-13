using UnityEngine;
using System;

public class LessonLoader : MonoBehaviour {
	public Camera c;
	private string currentLesson;

	void Start() {
		currentLesson = FlowControl.GetLesson ();
		if (currentLesson == null || "".Equals (currentLesson)) {
				currentLesson = "Lesson1";
		}

		gameObject.AddComponent (currentLesson);

		if (c != null) {
			TurnOffAR();
		}
	}

	public void TurnOffAR() {
		c.GetComponent<QCARBehaviour>().enabled = false;
	}

	public void TurnOnAR () {
		c.GetComponent<QCARBehaviour> ().enabled = true;
	}

	void OnGUI() {
		Slides currentSlides = FlowControl.GetCurrentSlides ();
		if (currentSlides.CurrentSlide ().GetSlideState () == Slide.SlideState.AR) {
			TurnOnAR ();
		} else {
			TurnOffAR ();
		}
	}

	public void Reload() {
		Start ();
	}
}
