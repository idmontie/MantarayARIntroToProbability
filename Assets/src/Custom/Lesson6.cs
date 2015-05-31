using System;
using UnityEngine;


public class Lesson6 : MonoBehaviour 
{
	Slides slides = null;
	
	void Start ()
	{
		slides = new Slides("Lesson6");
		
		slides.Add(new Slide(
			"Exercise 2: Discovering Probability\n\nIn the following exercise, you will practice calculating probability."
		));

		slides.Add (new Slide (
			"In this scenario, after a day of investigating fish, your boss wants you to report your findings to him!  Let's convert some of our findings to make it easier to understand!"
		));
		
		// ----------------------- Question Slide ---------------- //
		Slide qSlide = new Slide("");
		Question q = new Question();
		q.SetText("We have observed that 3 of 10 fish have been affected by pollution from one of our samples.  How do we express this as a ratio of affected fish to not affected fish?");
		q.SetAnswers("3:10", "3:7", "7:10", "3:5");
		q.SetRightAnswer("3:7");
		q.SetHint("Remember that ratios are the odds of one event happening compared to the odds of another event happening.");
		q.SetDescriptionOfRightAnswer("Great! If we have 3 affected fish, then that means we have 7 not affected fish.  Thus, the ratio is 3 to 7!");
		
		qSlide.AttachQuestion(q);
		slides.Add (qSlide);
		// -------------------------------------------------------- //
		
		// ----------------------- Question Slide ---------------- //
		qSlide = new Slide("");
		q = new Question();
		q.SetText("We have observed that 20% of fish have been affected by pollution from one of our samples.  How do we express this as a ratio of affected fish to not affected fish?");
		q.SetAnswers("2:10", "2:8", "8:10", "8:2");
		q.SetRightAnswer("2:8");
		q.SetHint("Remember that ratios are the odds of one event happening compared to the odds of another event happening.");
		q.SetDescriptionOfRightAnswer("Great! If we have 2 affected fish, then that means we have 8 not affected fish.  Thus, the ratio is 2 to 8!");
		
		qSlide.AttachQuestion(q);
		slides.Add (qSlide);
		// -------------------------------------------------------- //
		
		slides.Add(new Slide(
			"Your boss appreciates the work!  Converting your data into easy to understand formulas takes very little effort, but an effective means of communication!"
		));
	}
	
	void OnGUI () 
	{
		slides.OnGUI(gameObject);
	}
	
	void Update () 
	{
		slides.Update(gameObject);
	}
}
